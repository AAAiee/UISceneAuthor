// Copyright 2026 Lex. MIT License.

using UnrealBuildTool;

public class UISceneAuthor : ModuleRules
{
  public UISceneAuthor(ReadOnlyTargetRules Target) : base(Target)
  {
    PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

    PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine" });
  }
}
