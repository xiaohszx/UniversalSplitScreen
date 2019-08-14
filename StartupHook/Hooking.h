#pragma once
#include <easyhook.h>
#include <string>

NTSTATUS installHook(void* entryPoint, void* inCallback, std::string name);
NTSTATUS installHook(const LPCSTR moduleHandle, std::string lpProcName, void* inCallback);