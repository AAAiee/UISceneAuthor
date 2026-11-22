// Copyright 2026 Lex. MIT License.

using UnrealBuildTool;
using System.Collections.Generic;

public class UISceneAuthorHostEditorTarget : TargetRules
{
  public UISceneAuthorHostEditorTarget(TargetInfo Target) : base(Target)
  {
    Type = TargetType.Editor;
    DefaultBuildSettings = BuildSettingsVersion.V5;
    IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
    ExtraModuleNames.Add("UISceneAuthorHost");
  }
}
