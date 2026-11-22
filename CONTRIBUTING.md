# Contributing

This guide covers local setup, how to rebuild the modules after a C++ change, and the pull request format.

## Set up

1. Clone the repository.
2. Install Unreal Engine 5.6 from the Epic Games Launcher.
3. Install Visual Studio 2022 with the **Game development with C++** workload. UnrealBuildTool also needs a Windows 10 SDK at version 10.0.19041 or later. Without those, it reports that Win64 is not a valid platform to build.
4. Open `UISceneAuthor.uproject`. When Unreal offers to build the missing modules, accept.

## Rebuild the modules after a C++ change

1. Close the Unreal editor.
2. Right-click `UISceneAuthor.uproject` and select **Generate Visual Studio project files**.
3. Open `UISceneAuthor.sln` in Visual Studio.
4. Select the **Development Editor** configuration and the **Win64** platform.
5. Build the `UISceneAuthorHostEditor` target.
6. Open `UISceneAuthor.uproject` again.

You can also rebuild from a Developer Command Prompt without opening Visual Studio. Run this from the repository root.

```text
"C:\Program Files\Epic Games\UE_5.6\Engine\Build\BatchFiles\Build.bat" UISceneAuthorHostEditor Win64 Development -Project="%CD%\UISceneAuthor.uproject" -WaitMutex
```

## Send a pull request

1. Branch from `main`.
2. Keep one purpose per pull request.
3. Title the pull request as `type(scope): subject`. Use types such as `feat`, `fix`, `docs`, and `chore`. Use scopes such as `plugin`, `host`, and `ci`.
4. Fill in the pull request template. Its headings are Why, What changed, Scope, Tradeoffs, Blast Radius, and Verification.
5. Verify the change before you push. Build the editor target for a C++ change, and check the links for a docs change.
