// Copyright 2026 Lex. MIT License.

using UnrealBuildTool;

public class UISceneAuthorEditor : ModuleRules
{
  public UISceneAuthorEditor(ReadOnlyTargetRules Target) : base(Target)
  {
    PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

    PublicDependencyModuleNames.AddRange(new string[] { "UISceneAuthor" });

    PrivateDependencyModuleNames.AddRange(new string[] { "UnrealEd", "Slate", "SlateCore", "Core", "CoreUObject", "Engine" });
  }
}
