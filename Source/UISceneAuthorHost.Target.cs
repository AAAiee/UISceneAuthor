// Copyright 2026 Lex. MIT License.

using UnrealBuildTool;
using System.Collections.Generic;

public class UISceneAuthorHostTarget : TargetRules
{
  public UISceneAuthorHostTarget(TargetInfo Target) : base(Target)
  {
    Type = TargetType.Game;
    DefaultBuildSettings = BuildSettingsVersion.V5;
    IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
    ExtraModuleNames.Add("UISceneAuthorHost");
  }
}
