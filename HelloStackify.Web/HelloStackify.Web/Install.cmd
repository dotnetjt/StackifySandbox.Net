md "%~dp0appdata"
reg add "hku\.default\software\microsoft\windows\currentversion\explorer\user shell folders" /v "Local AppData" /t REG_EXPAND_SZ /d "%~dp0appdata" /f
powershell -ExecutionPolicy Unrestricted .\Install.ps1 %ACTIVATIONKEY% %ENVIRONMENT%