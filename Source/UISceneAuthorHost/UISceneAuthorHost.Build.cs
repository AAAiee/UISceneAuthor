// Copyright 2026 Lex. MIT License.

using UnrealBuildTool;

public class UISceneAuthorHost : ModuleRules
{
  public UISceneAuthorHost(ReadOnlyTargetRules Target) : base(Target)
  {
    PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

    PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
  }
}
