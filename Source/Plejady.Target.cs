// Copyright Plejady Team

using UnrealBuildTool;
using System.Collections.Generic;

public class PlejadyTarget : TargetRules
{
	public PlejadyTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "Plejady" } );
	}
}
