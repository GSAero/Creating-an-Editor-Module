// Fill out your copyright notice in the Description page of Project Settings.

#include "MyGameEditor.h"
#include "Modules/ModuleManager.h"
#include "Modules/ModuleInterface.h"

IMPLEMENT_GAME_MODULE(FMyGameEditorModule, MyGameEditor);

DEFINE_LOG_CATEGORY(MyGameEditor)

#define LOCTEXT_NAMESPACE "MyGameEditor"

void FMyGameEditorModule::StartupModule()
{
	UE_LOG(MyGameEditor, Warning, TEXT("MyGameEditor: Log Started"));
}

void FMyGameEditorModule::ShutdownModule()
{
	UE_LOG(MyGameEditor, Warning, TEXT("MyGameEditor: Log Ended"));
}

#undef LOCTEXT_NAMESPACE

