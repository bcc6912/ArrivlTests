using UnrealBuildTool;

public class ArrivlTest1ServerTarget : TargetRules
{
	public ArrivlTest1ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ArrivlTest1");
	}
}
