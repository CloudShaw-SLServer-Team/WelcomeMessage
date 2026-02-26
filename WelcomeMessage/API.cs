using LabApi.Features.Console;
using LabApi.Features.Wrappers;
using System.Collections.Generic;
using WelcomeMessage.Enums;

namespace WelcomeMessage
{
    public static class API
    {
        public static Dictionary<string, string> ColorCodes = new Dictionary<string, string>
        {
            { "gold","#EFC01A" },
            { "teal","#008080" },
            { "blue","#005EBC" },
            { "purple","#8137CE" },
            { "light_red","#FD8272" },
            { "pink", "#FF96DE" },
            { "red", "#C50000" },
            { "default","#FFFFFF" },
            { "brown", "#944710" },
            { "silver", "#A0A0A0" },
            { "light_green", "#32CD32" },
            { "crimson", "#DC143C" },
            { "cyan", "#00B7EB" },
            { "aqua", "#00FFFF" },
            { "deep_pink", "#FF1493" },
            { "tomato", "#FF6448" },
            { "yellow", "#FAFF86" },
            { "magenta", "#FF0090" },
            { "blue_green", "#4DFFB8" },
            { "silver_blue","#666699" },
            { "orange", "#FF9966" },
            { "police_blue","#002DB3" },
            { "lime", "#BFFF00" },
            { "green", "#228B22" },
            { "emerald", "#50C878" },
            { "carmine", "#960018" },
            { "nickel", "#727472" },
            { "mint", "#98FB98" },
            { "army_green", "#4B5320" },
            { "pumpkin", "#EE7600" }
        };
        public static string ToColorCode(this string groupColor)
        {
            if (groupColor == null)
            {
                return "#FFFFFF";
            }
            if (ColorCodes.TryGetValue(groupColor, out string colorCode))
            {
                return colorCode;
            }
            return "#FFFFFF";
        }
        public static void SendMessage(this Player player)
        {
            Logger.Debug($"向 {player.Nickname} 发送欢迎消息，类型为 {PluginMain.Instance.Config.MessageType}", PluginMain.Instance.Config.Debug);
            switch (PluginMain.Instance.Config.MessageType)
            {
                case MessageType.Hint:
                    player.SendHint(PluginMain.Instance.Config.MessageText.Replace("{name}", player.Nickname).Replace("{color}", player.GroupColor.ToColorCode()), PluginMain.Instance.Config.MessageSeconds);
                    break;
                case MessageType.Broadcast:
                    player.SendBroadcast(PluginMain.Instance.Config.MessageText.Replace("{name}", player.Nickname).Replace("{color}", player.GroupColor.ToColorCode()), PluginMain.Instance.Config.MessageSeconds);
                    break;
            }
            Logger.Info($"已向 {player.Nickname} 显示欢迎消息");
        }
    }
}
