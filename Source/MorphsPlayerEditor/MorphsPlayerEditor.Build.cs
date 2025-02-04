﻿// Copyright (c) Yevhenii Selivanov.

using UnrealBuildTool;

public class MorphsPlayerEditor : ModuleRules
{
    public MorphsPlayerEditor(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        CppStandard = CppStandardVersion.Latest;
        bEnableNonInlinedGenCppWarnings = true;

        PublicDependencyModuleNames.AddRange(new[]
            {
                "Core"
            }
        );

        PrivateDependencyModuleNames.AddRange(new[]
            {
                "CoreUObject", "Engine", "Slate", "SlateCore" // Core
                , "ToolWidgets" // SSearchableComboBox
                // My modules
                , "MorphsPlayer" // FMorphData
            }
        );
    }
}