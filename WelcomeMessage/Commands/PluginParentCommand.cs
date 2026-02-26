using CommandSystem;
using System;

namespace WelcomeMessage.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class PluginParentCommand : ParentCommand
    {
        public override string Command { get; } = "welcomemessage";
        public override string[] Aliases { get; } = new string[] { "ws" };
        public override string Description { get; } = "";
        protected override bool ExecuteParent(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "可使用以下指令：\n" +
                "reload - 重新载入配置文件\n" +
                "show - 对指定玩家显示欢迎消息";
            return true;
        }
        public override void LoadGeneratedCommands()
        {

        }
    }
}
