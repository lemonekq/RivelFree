:: rivel free, made in batch for easier support
@echo off
mode 80, 50

:: plugins@start
SETLOCAL EnableExtensions DisableDelayedExpansion
for /F %%a in ('echo prompt $E ^| cmd') do (
  set "ESC=%%a"
)
echo %ESC%[4mUnderline DisableDelayedExpansion%ESC%[0m
Set "Path=%Path%;%CD%;%CD%\src;"
SETLOCAL EnableDelayedExpansion
:: plugins@end

color 0f
cls
goto main

:main
echo !ESC![35m __________.__             .__  ___________                      
echo !ESC![95m \______   \__I__  __ ____ I  I \_   _____/______   ____   ____   !ESC![0m
echo !ESC![35m  I       _/  \  \/ // __ \I  I  I    __) \_  __ \_/ __ \_/ __ \  !ESC![0m
echo !ESC![95m  I    I   \  I\   /\  ___/I  I__I     \   I  I \/\  ___/\  ___/  !ESC![0m
echo !ESC![35m  I____I_  /__I \_/  \___  @____/\___  /   I__I    \___  @\___  @ !ESC![0m
echo !ESC![95m         \/              \/          \/                \/     \/  !ESC![0m
echo                                               !ESC![92mlemonekq/rivelfree!ESC![0m
echo.
echo      Tools:
:: buttons
echo.
echo.
echo.
echo.
echo.
echo      Misc:
call Button 5 10 5F "Network" 16 10 5F "Latency" 27 10 5F "Tweaks"  37 10 5F "Optimization" 5 16 DF "Hardware" 17 16 DF "About" X _Var_Box _Var_Hover
echo.
echo.
echo.
GetInput /M %_Var_Box% /H %_Var_Hover%
if %Errorlevel%==1

