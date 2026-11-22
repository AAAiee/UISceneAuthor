# UI Scene Author

UI Scene Author 是一个 Unreal Engine 5.6 插件，用于编写具名的 UMG 数据场景，并对场景运行布局检查。计划是让人和 AI 代理以后通过同一个命令层来驱动插件。该命令层尚未实现。

## 状态

项目处于 pre-alpha 阶段。0.1.0 是一个地基版本。模块是空骨架，只包含一个日志类别。没有编辑器界面，也没有游戏逻辑代码。请勿假设这里的任何内容已经稳定。

## 插件的目标形态

目标是让插件支持这样的流程。你把一个界面场景写成具名数据，然后对它运行布局检查。同样的命令以后应当既能在编辑器里由人使用，也能被外部的 AI 代理调用。0.1.0 只交付承载这些命令的仓库结构，不交付更多。

## 环境要求

- Unreal Engine 5.6 启动器版本，引擎关联为 `5.6`。
- Windows。
- Visual Studio 2022，安装 **Game development with C++** 工作负载，用于编译 C++ 模块。

## 运行宿主工程

仓库根目录是宿主工程。它存在的原因是插件的编辑器代码需要一个可编译的目标。

1. 克隆本仓库。
2. 打开 `UISceneAuthor.uproject`。Unreal 提示编译缺失的模块时，选择接受。
3. 如果 Unreal 没有启动，右键点击 `UISceneAuthor.uproject`，选择 **Generate Visual Studio project files**，然后再次打开 `UISceneAuthor.uproject`。

## 在其他工程中使用插件

插件是自包含的，不依赖宿主工程。

1. 把 `Plugins/UISceneAuthor` 复制到一个 Unreal Engine 5.6 工程的 `Plugins` 目录。
2. 在 Unreal 中打开该工程，在插件浏览器中启用 **UI Scene Author**，然后按提示重启编辑器。Unreal 会在重启时编译插件模块。

## 仓库布局

```text
UISceneAuthor.uproject      宿主工程。
Config/                     默认的引擎、游戏、编辑器与输入设置。
Content/                    空目录。
Source/                     宿主目标文件与 UISceneAuthorHost 游戏模块。
Plugins/UISceneAuthor/      插件本体。复制这个目录即可在别处使用。
```

## 文档

- [架构说明](Docs/architecture.md) 讲解宿主工程、两个插件模块，以及 0.1.0 为什么没有定义类型。
- [贡献指南](CONTRIBUTING.md) 讲解开发环境与拉取请求格式。
- [更新日志](CHANGELOG.md) 记录版本变化。
- [安全策略](SECURITY.md) 说明漏洞报告方式。

## 许可证

MIT 许可证，见 [LICENSE](LICENSE)。

## English

本说明另有 [English](README.md) 版本。
