// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class MyGameEditor : ModuleRules
{
    public MyGameEditor(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

        PublicIncludePaths.AddRange(new string[] { "MyGameEditor/Public" });
        PrivateIncludePaths.AddRange(new string[] { "MyGameEditor/Private" });
        PublicDependencyModuleNames.AddRange(new string[] { "MyGame" });
        PrivateDependencyModuleNames.AddRange(new string[] {  });
        //PrivateDependencyModuleNames.AddRange(new string[] { "UnrealEd" });
        PrivateIncludePathModuleNames.AddRange(new string[] {  });
        DynamicallyLoadedModuleNames.AddRange(new string[] {  });
    }
}
