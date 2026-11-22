# Architecture

This page explains the repository shape and the module split, and records why version 0.1.0 defines no reflected types. It is explanation, not a setup guide. For setup steps, read [CONTRIBUTING.md](../CONTRIBUTING.md).

## Host project and plugin

The repository holds two things. The root is the host project, `UISceneAuthor.uproject`. The plugin lives at `Plugins/UISceneAuthor`. The layout follows the host-plus-plugin shape used by AAAiee/UE5-PathFinding-Plugin.

The host exists so the plugin has a build target. Unreal compiles plugin editor code against a project's editor target, and a plugin folder alone carries no targets. `Source/` supplies the host game target, the host editor target, and the `UISceneAuthorHost` game module. Opening the host project gives the editor modules a place to build and load.

The host does not depend on the plugin. `UISceneAuthorHost.Build.cs` lists only engine modules, and the host module contains a primary game module macro and nothing else. The `.uproject` file enables the plugin. Because the plugin never reaches into host code, `Plugins/UISceneAuthor` is self-contained. Copying that folder into another project carries everything the plugin needs.

## Runtime module and editor module

`UISceneAuthor` is the runtime module. It loads in packaged games and in the editor. It declares the log category `LogUISceneAuthor` and depends only on `Core`, `CoreUObject`, and `Engine`. The module class `FUISceneAuthorModule` lives in the public header so later code can call `FModuleManager::GetModuleChecked`.

`UISceneAuthorEditor` is the editor module. It loads only inside the editor, and only on the whitelisted platforms `Win64`, `Linux`, and `Mac`. It depends on the runtime module plus editor-only modules, including `UnrealEd`, `Slate`, and `SlateCore`. The module class `FUISceneAuthorEditorModule` lives in the public header for the same reason.

The `.uplugin` file is the source of truth for the module names, the engine version, and how and when each module loads. The `Build.cs` files declare dependencies only. When a fact about modules changes, change the `.uplugin` first.

## Why version 0.1.0 defines no types

The public data shape of the plugin is its scene model. That model needs a design pass against a running editor before it is worth freezing into generated headers. Empty modules keep this commit reviewable as pure structure, and the first data model then lands as one visible change.

`StartupModule` and `ShutdownModule` are empty on purpose. Nothing needs initializing yet, and stub code that only writes a log line would be noise.

## What stays out of this commit

The command layer comes later. People and AI agents are meant to drive one command set, so the scene data model has to exist first. No commands, no editor UI, and no UMG dependency are in 0.1.0. The runtime module does not link UMG because nothing uses it yet.
