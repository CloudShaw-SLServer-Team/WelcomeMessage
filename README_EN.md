# Welcome Message
![Version](https://img.shields.io/github/v/release/CloudShaw-SLServer-Team/WelcomeMessage?label=Version)
![Downloads](https://img.shields.io/github/downloads/CloudShaw-SLServer-Team/WelcomeMessage/total?label=Downloads&color=yellow)

[中文](README.md) | English

A SCP: Secret Laboratory plugin based on LabAPI that displays a welcome message when a player joins the server. It can display the player's name in the color of their group.

## 🚀 How to Use
1. Download the latest version of the plugin from the [Releases](https://github.com/CloudShaw-SLServer-Team/WelcomeMessage/releases/latest) page.

2. Copy the downloaded plugin file to the plugin directory of your server (paths are listed below).
- **Windows**: `%AppData%\SCP Secret Laboratory\LabAPI\plugins`
- **Linux**: `~/.config/SCP Secret Laboratory/LabAPI/plugins`

3. Start or restart your server, and the plugin will load automatically.

4. In the server console, you should see a confirmation message similar to the following:
```
[INFO] [LabApi] [LOADER] Successfully enabled 'WelcomeMessage', Version: 1.0.0, Author: 'CloudShaw-SLServer-Team'
```

## ⚙ Configuration
Two types of parameters are provided to customize the message content.

| Parameter |    Meaning    |      Example      |
| :-------: | :-----------: | :---------------: |
|   name    | Player's name | Welcome `{name}` to the server |
|   color   | Player's group color | Welcome `<color={color}>`CloudShaw`</color>` to the server |

## 📝 Issues & Feedback
If you encounter any problems during use, please report them on the [Issues](https://github.com/CloudShaw-SLServer-Team/WelcomeMessage/issues) page.

## 📜 License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.