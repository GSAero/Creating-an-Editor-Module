// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class MyGameTarget : TargetRules
{
	public MyGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "MyGame" } );

        if (bBuildEditor)
        {
            ExtraModuleNames.AddRange(new string[] { "MyGameEditor" });
        }

    }
}
