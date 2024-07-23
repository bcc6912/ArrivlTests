using UnrealBuildTool;

public class ArrivlTest1ClientTarget : TargetRules
{
	public ArrivlTest1ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ArrivlTest1");
	}
}
