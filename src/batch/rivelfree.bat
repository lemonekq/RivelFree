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
echo !ESC![35m  I____I_  /__I \_/  \___  '____/\___  /   I__I    \___  '\___  ' !ESC![0m
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
if %Errorlevel%==1 goto network
if %Errorlevel%==2 goto latency
if %Errorlevel%==3 goto tweaks
if %Errorlevel%==4 goto optimization
if %Errorlevel%==5 goto hardware
if %Errorlevel%==6 goto about
:: anti error // close
cls
goto main

:network
echo !ESC![35m  _______          __                       __    
echo !ESC![95m  \      \   _____/  I___  _  _____________I  I __
echo !ESC![35m  /   I   \_/ __ \   __\ \/ \/ /  _ \_  __ \  I/ /
echo !ESC![95m /    I    \  ___/I  I  \     (  '_' )  I \/    ' 
echo !ESC![35m \____I__  /\___  '__I   \/\_/ \____/I__I  I__I_ \
echo !ESC![95m         \/     \/                              \/

:latency
echo .____            __                              
echo I    I   _____ _/  I_  ____   ____   ____ ___.__.
echo I    I   \__  \\   __\/ __ \ /    \_/ ___'   I  I
echo I    I___ / __ \I  I \  ___/I   I  \  \___\___  I
echo I_______ (____  /__I  \___  '___I  /\___  ' ____I
echo         \/    \/          \/     \/     \/\/     

:tweaks
echo ___________                      __            
echo \__    ___/_  _  __ ____ _____  I  I __  ______
echo   I    I  \ \/ \/ // __ \\__  \ I  I/ / /  ___/
echo   I    I   \     /\  ___/ / __ \I    '  \___ \ 
echo   I____I    \/\_/  \___  '____  /__I_ \/____  '
echo                        \/     \/     \/     \/ 
					   
:optimization
echo ________          __  .__        .__                __  .__               
echo \_____  \ _______/  I_I__I _____ I__I____________ _/  I_I__I ____   ____  
echo  /   I   \\____ \   __\  I/     \I  \___   /\__  \\   __\  I/  _ \ /    \ 
echo /    I    \  I_' '  I I  I  Y Y  \  I/    /  / __ \I  I I  (  '_' )   I  \
echo \_______  /   __/I__I I__I__I_I  /__/_____ \(____  /__I I__I\____/I___I  /
echo         \/I__I                 \/         \/     \/                    \/ 

:hardware
echo   ___ ___                  .___                              
echo  /   I   \_____ _______  __I _/_  _  _______ _______   ____  
echo /    ~    \__  \\_  __ \/ __ I\ \/ \/ /\__  \\_  __ \_/ __ \ 
echo \    Y    // __ \I  I \/ /_/ I \     /  / __ \I  I \/\  ___/ 
echo  \___I_  /(____  /__I  \____ I  \/\_/  (____  /__I    \___  '
echo        \/      \/           \/              \/            \/ 
	   
:about
echo    _____ ___.                  __   
echo   /  _  \\_ I__   ____  __ ___/  I_ 
echo  /  /_\  \I __ \ /  _ \I  I  \   __\
echo /    I    \ \_\ (  '_' )  I  /I  I  
echo \____I__  /___  /\____/I____/ I__I  
echo         \/    \/                    