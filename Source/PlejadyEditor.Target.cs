// Copyright Plejady Team

using UnrealBuildTool;
using System.Collections.Generic;

public class PlejadyEditorTarget : TargetRules
{
	public PlejadyEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Plejady" } );
	}
}
