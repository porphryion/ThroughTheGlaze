// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ThroughTheGlaze : ModuleRules
{
	public ThroughTheGlaze(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ThroughTheGlaze",
			"ThroughTheGlaze/Variant_Horror",
			"ThroughTheGlaze/Variant_Horror/UI",
			"ThroughTheGlaze/Variant_Shooter",
			"ThroughTheGlaze/Variant_Shooter/AI",
			"ThroughTheGlaze/Variant_Shooter/UI",
			"ThroughTheGlaze/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
