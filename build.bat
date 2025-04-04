@echo off
REM Cleanup old nuitka-crash-report.xml
if exist nuitka-crash-report.xml del nuitka-crash-report.xml

REM Compile the Python script with Nuitka
nuitka --onefile --standalone --windows-icon-from-ico=gmapgen.ico --remove-output --windows-console-mode=disable --enable-plugin=tk-inter --output-dir=./ --output-filename=gmapgen.exe --msvc=latest gmapgen.py --show-progress
pause
