using UnrealBuildTool;

public class ArrivlTest1Target : TargetRules
{
	public ArrivlTest1Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ArrivlTest1");
	}
}
