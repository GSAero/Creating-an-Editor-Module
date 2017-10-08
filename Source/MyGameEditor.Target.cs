// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class MyGameEditorTarget : TargetRules
{
	public MyGameEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "MyGame" } );

        // Game editor
        ExtraModuleNames.AddRange(new string[] { "MyGameEditor" });
    }
}
