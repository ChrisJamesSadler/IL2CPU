IF EXIST "%PROGRAMFILES(X86)%" (GOTO 64BIT) ELSE (GOTO 32BIT)

:64BIT
Install/64-Bit.bat
GOTO END

:32BIT
Install/32-Bit.bat
GOTO END

:END