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
echo  _______          __                       __    
echo  \      \   _____/  |___  _  _____________|  | __
echo  /   |   \_/ __ \   __\ \/ \/ /  _ \_  __ \  |/ /
echo /    |    \  ___/|  |  \     (  <_> )  | \/    < 
echo \____|__  /\___  >__|   \/\_/ \____/|__|  |__|_ \
echo         \/     \/                              \/

:latency
echo .____            __                              
echo |    |   _____ _/  |_  ____   ____   ____ ___.__.
echo |    |   \__  \\   __\/ __ \ /    \_/ ___<   |  |
echo |    |___ / __ \|  | \  ___/|   |  \  \___\___  |
echo |_______ (____  /__|  \___  >___|  /\___  > ____|
echo         \/    \/          \/     \/     \/\/     

:tweaks
echo ___________                      __            
echo \__    ___/_  _  __ ____ _____  |  | __  ______
echo   |    |  \ \/ \/ // __ \\__  \ |  |/ / /  ___/
echo   |    |   \     /\  ___/ / __ \|    <  \___ \ 
echo   |____|    \/\_/  \___  >____  /__|_ \/____  >
echo                        \/     \/     \/     \/ 
					   
:optimization
echo ________          __  .__        .__                __  .__               
echo \_____  \ _______/  |_|__| _____ |__|____________ _/  |_|__| ____   ____  
echo  /   |   \\____ \   __\  |/     \|  \___   /\__  \\   __\  |/  _ \ /    \ 
echo /    |    \  |_> >  | |  |  Y Y  \  |/    /  / __ \|  | |  (  <_> )   |  \
echo \_______  /   __/|__| |__|__|_|  /__/_____ \(____  /__| |__|\____/|___|  /
echo         \/|__|                 \/         \/     \/                    \/ 

:hardware
echo   ___ ___                  .___                              
echo  /   |   \_____ _______  __| _/_  _  _______ _______   ____  
echo /    ~    \__  \\_  __ \/ __ |\ \/ \/ /\__  \\_  __ \_/ __ \ 
echo \    Y    // __ \|  | \/ /_/ | \     /  / __ \|  | \/\  ___/ 
echo  \___|_  /(____  /__|  \____ |  \/\_/  (____  /__|    \___  >
echo        \/      \/           \/              \/            \/ 
	   
:about
echo    _____ ___.                  __   
echo   /  _  \\_ |__   ____  __ ___/  |_ 
echo  /  /_\  \| __ \ /  _ \|  |  \   __\
echo /    |    \ \_\ (  <_> )  |  /|  |  
echo \____|__  /___  /\____/|____/ |__|  
echo         \/    \/                    