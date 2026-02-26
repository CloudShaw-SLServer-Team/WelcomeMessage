using System.ComponentModel;
using WelcomeMessage.Enums;

namespace WelcomeMessage
{
    public class Config
    {
        [Description("是否启用插件")]
        public bool IsEnabled { get; set; } = true;
        [Description("是否启用调试模式")]
        public bool Debug { get; set; } = false;
        [Description("是否启用自动重载配置文件")]
        public bool AutoReload { get; set; } = true;
        [Description("自动重载间隔的时间，默认每10秒重载，单位：秒")]
        public float AutoReloadInterval { get; set; } = 10f;
        [Description("消息的时长")]
        public byte MessageSeconds { get; set; } = 5;
        [Description("消息的显示形式，设置为 Hint 以提示的方式显示，Broadcast 以广播的方式显示")]
        public MessageType MessageType { get; set; } = MessageType.Hint;
        [Description("消息的内容")]
        public string MessageText { get; set; } = "<size=67%><b><color={color}>{name}</color> 欢迎进入服务器</b></size>";
    }
}
