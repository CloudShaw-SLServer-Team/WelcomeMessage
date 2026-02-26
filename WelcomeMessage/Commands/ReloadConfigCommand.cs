using CommandSystem;
using System;

namespace WelcomeMessage.Commands
{
    [CommandHandler(typeof(PluginParentCommand))]
    public class ReloadConfigCommand : ICommand
    {
        public string Command { get; } = "reload";
        public string[] Aliases { get; } = new string[] { "reload" };
        public string Description { get; } = "重新载入配置文件";
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            PluginMain.Instance.ReloadConfig();
            response = "配置文件已重载";
            return true;
        }
    }
}
