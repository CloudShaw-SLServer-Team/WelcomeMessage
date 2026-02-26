# Welcome Message
![Version](https://img.shields.io/github/v/release/CloudShaw-SLServer-Team/WelcomeMessage?label=Version)
![Downloads](https://img.shields.io/github/downloads/CloudShaw-SLServer-Team/WelcomeMessage/total?label=Downloads&color=yellow)

中文 | [English](README_EN.md)

一个基于 LabAPI 的 SCP: Secret Laboratory 插件，当玩家进入服务器时会显示欢迎消息。可根据玩家的组的颜色显示玩家的姓名。

## 🚀 如何使用
1. 在 [Releases](https://github.com/CloudShaw-SLServer-Team/WelcomeMessage/releases/latest) 页面下载最新版本的插件

2. 将下载的插件文件复制到服务器的插件目录中（路径见下文）
- **Windows**：`%AppData%\SCP Secret Laboratory\LabAPI\plugins`
- **Linux**：`~/.config/SCP Secret Laboratory/LabAPI/plugins`

3. 启动或重启你的服务器，插件将自动加载

4. 在服务器控制台中，你应该会看到类似以下的确认信息
```
[INFO] [LabApi] [LOADER] Successfully enabled 'WelcomeMessage', Version: 1.0.0, Author: 'CloudShaw-SLServer-Team'
```

## ⚙ 配置
提供两种类型的参数，用于自定义消息内容。
| 参数名称 |      含义       |        示例        |
| :-----: | :------------: | :----------------: |
|  name   |  代表玩家的名字  | 欢迎`{name}`进入服务器 |
|  color  | 代表玩家组的颜色 | 欢迎`<color={color}>`小知章`</color>`进入服务器 |

## 📝 问题与反馈
如果你在使用过程中遇到任何问题，请在 [Issues](https://github.com/CloudShaw-SLServer-Team/WelcomeMessage/issues) 页面提交问题报告。

## 📜 许可证
本项目采用 MIT 许可证授权。详情请参阅 [LICENSE](LICENSE) 文件。