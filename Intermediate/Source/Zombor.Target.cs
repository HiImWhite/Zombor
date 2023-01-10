using UnrealBuildTool;

public class ZomborTarget : TargetRules
{
	public ZomborTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Zombor");
	}
}
