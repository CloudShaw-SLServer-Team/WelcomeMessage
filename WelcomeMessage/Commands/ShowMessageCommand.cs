using CommandSystem;
using LabApi.Features.Wrappers;
using System;

namespace WelcomeMessage.Commands
{
    [CommandHandler(typeof(PluginParentCommand))]
    public class ShowMessageCommand : ICommand
    {
        public string Command { get; } = "show";
        public string[] Aliases { get; } = new string[] { "show" };
        public string Description { get; } = "显示欢迎消息给玩家";
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (arguments.Count == 0)
            {
                response = "用法: welcomemessage show [PlayerID]";
                return true;
            }
            var player = Player.Get(int.Parse(arguments.Array[2]));
            if (player == null)
            {
                response = "尝试获取玩家信息失败\n" +
                    "用法: welcomemessage show [PlayerID]";
                return true;
            }
            player.SendMessage();
            response = $"已向 {player.Nickname} 显示欢迎消息";
            return true;
        }
    }
}
