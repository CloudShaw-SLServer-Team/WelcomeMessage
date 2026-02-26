using LabApi.Events.Arguments.PlayerEvents;
using LabApi.Events.Handlers;
using LabApi.Features;
using LabApi.Features.Console;
using LabApi.Loader;
using LabApi.Loader.Features.Plugins;
using MEC;
using System;
using System.Collections.Generic;

namespace WelcomeMessage
{
    public class PluginMain : Plugin
    {
        public override string Name { get; } = "WelcomeMessage";
        public override string Description { get; } = "在玩家进入游戏时显示欢迎信息";
        public override string Author { get; } = "CloudShaw-SLServer-Team";
        public override Version Version { get; } = new Version("1.0.0");
        public override Version RequiredApiVersion { get; } = new Version(LabApiProperties.CompiledVersion);
        public static PluginMain Instance;
        public CoroutineHandle AutoReloadCoroutine;
        public Config Config;
        public override void Enable()
        {
            Instance = this;
            if (Config.AutoReload)
            {
                AutoReloadCoroutine = Timing.RunCoroutine(ReloadConfigTimer());
            }
            PlayerEvents.Joined += OnPlayerJoined;
        }
        public override void Disable()
        {
            Timing.KillCoroutines(AutoReloadCoroutine);
            PlayerEvents.Joined -= OnPlayerJoined;
        }
        public override void LoadConfigs()
        {
            Config = this.LoadConfig<Config>("config.yml");
            if (Config.AutoReloadInterval <= 0f)
            {
                Config.AutoReloadInterval = 1f;
                Logger.Warn("Config.yml 中的 AutoReloadInterval 不能为0，已自动将其设置为1秒");
            }
        }
        public void ReloadConfig()
        {
            bool oldAutoReload = Config.AutoReload;
            LoadConfigs();
            if (oldAutoReload == Config.AutoReload)
            {
                return;
            }
            if (Config.AutoReload)
            {
                AutoReloadCoroutine = Timing.RunCoroutine(ReloadConfigTimer());
            }
            else
            {
                Timing.KillCoroutines(AutoReloadCoroutine);
            }
        }
        public IEnumerator<float> ReloadConfigTimer()
        {
            while (Config.AutoReload)
            {
                yield return Timing.WaitForSeconds(Config.AutoReloadInterval);
                LoadConfigs();
                Logger.Debug("已自动重载配置文件", Config.Debug);
            }
        }
        public void OnPlayerJoined(PlayerJoinedEventArgs ev)
        {
            if (!Config.IsEnabled)
            {
                return;
            }
            ev.Player.SendMessage();
            return;
        }
    }
}
