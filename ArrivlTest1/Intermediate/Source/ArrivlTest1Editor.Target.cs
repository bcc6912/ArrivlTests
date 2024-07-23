using UnrealBuildTool;

public class ArrivlTest1EditorTarget : TargetRules
{
	public ArrivlTest1EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ArrivlTest1");
	}
}
