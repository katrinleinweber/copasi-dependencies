@echo off
REM 
REM Utility script building all VS11 release / debug projects
REM 

SET THIS_DIR=%~dp0
SET VC_VARS=c:\Program Files (x86)\Microsoft Visual Studio 11.0\VC\vcvarsall.bat
SET CMAKE_OVERRIDES=-DWITH_STATIC_RUNTIME=ON 

REM set up 64bit environment
call  "%VC_VARS%" x86_amd64
title Building x64 debug
cd /d %THIS_DIR%
call createX86_vs11_x64_debug 
move bin bin_vs11_static_x64_debug
move tmp tmp_vs11_static_x64_debug

title Building x64 release
cd /d %THIS_DIR%
call createX86_vs11_x64_release 
move bin bin_vs11_static_x64_release
move tmp tmp_vs11_static_x64_release

REM set up 32bit environment
call  "%VC_VARS%" x86
title Building x86 debug
cd /d %THIS_DIR%
call createX86_vs11_x86_debug 
move bin bin_vs11_x86_debug_static
move tmp tmp_vs11_x86_debug_static

title Building x86 release
cd /d %THIS_DIR%
call createX86_vs11_x86_release 
move bin bin_vs11_x86_release_static
move tmp tmp_vs11_x86_release_static

