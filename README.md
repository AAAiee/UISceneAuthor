# UI Scene Author

UI Scene Author is an Unreal Engine 5.6 plugin for authoring named UMG data scenes and running layout checks on them. The plan is that people and AI agents drive the same command layer later. That layer is not built yet.

## Status

Pre-alpha. Version 0.1.0 is a foundation. The modules are empty skeletons with one log category. There is no editor UI and no gameplay code. Do not build on the expectation that anything here is stable.

## What the plugin will be

The goal is a plugin where you author a UI scene as named data, then run layout checks on it. The same commands should later work for a person in the editor and for an AI agent driving the editor from outside. Version 0.1.0 ships the repository structure those commands will grow in, and nothing else.

## Requirements

- Unreal Engine 5.6, launcher build, engine association `5.6`.
- Windows.
- Visual Studio 2022 with the **Game development with C++** workload, for compiling the C++ modules.

## Run the host project

The repository root is the host project. It exists so the plugin editor code has a target to compile against.

1. Clone the repository.
2. Open `UISceneAuthor.uproject`. When Unreal offers to build the missing modules, accept.
3. If Unreal does not start, right-click `UISceneAuthor.uproject` and select **Generate Visual Studio project files**, then open `UISceneAuthor.uproject` again.

## Use the plugin in another project

The plugin is self-contained and does not need the host project.

1. Copy `Plugins/UISceneAuthor` into the `Plugins` folder of an Unreal Engine 5.6 project.
2. Open the project in Unreal. Enable **UI Scene Author** in the plugin browser, then restart the editor when it asks. Unreal compiles the plugin during the restart.

## Repository layout

```text
UISceneAuthor.uproject      Host project.
Config/                     Default engine, game, editor, and input settings.
Content/                    Empty.
Source/                     Host targets and the UISceneAuthorHost game module.
Plugins/UISceneAuthor/      The plugin. Copy this folder to use it elsewhere.
```

## Documentation

- [Architecture](Docs/architecture.md) explains the host project, the two plugin modules, and why 0.1.0 defines no types.
- [Contributing](CONTRIBUTING.md) covers the development setup and the pull request format.
- [Changelog](CHANGELOG.md) records what changed.
- [Security policy](SECURITY.md) covers how to report a vulnerability.

## License

MIT. See [LICENSE](LICENSE).

## 简体中文

This readme also exists in [简体中文](README.zh-CN.md).
