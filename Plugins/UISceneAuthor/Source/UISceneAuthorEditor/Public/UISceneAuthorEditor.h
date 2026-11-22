// Copyright 2026 Lex. MIT License.

#pragma once

#include "CoreMinimal.h"
#include "Modules/ModuleManager.h"

class FUISceneAuthorEditorModule : public IModuleInterface
{
public:
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};
