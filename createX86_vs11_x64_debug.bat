@echo off
SET BASE_DIR=%~dp0
Setlocal EnableDelayedExpansion

if "%INCLUDE%"=="" call  "c:\Program Files (x86)\Microsoft Visual Studio 11.0\VC\vcvarsall.bat" x86_amd64

if "%QTDIR%"=="" SET QTDIR=C:\Qt\qt-everywhere-opensource-src-4.8.2
if "%QMAKESPEC%"=="" SET QMAKESPEC=win32-msvc2010

SET BUILD_TYPE=Debug

SET BUILD_TOOL=nmake
SET BUILD_COMMAND=
SET INSTALL_COMMAND=install
SET CMAKE=cmake -G "NMake Makefiles"  %CMAKE_OVERRIDES% 

if not exist %BASE_DIR%\tmp mkdir %BASE_DIR%\tmp
if not exist %BASE_DIR%\bin mkdir %BASE_DIR%\bin
if not exist %BASE_DIR%\bin\include mkdir %BASE_DIR%\bin\include
if not exist %BASE_DIR%\bin\lib mkdir %BASE_DIR%\bin\lib


REM Build Clapack
mkdir %BASE_DIR%\tmp\clapack
cd /d %BASE_DIR%\tmp\clapack
%CMAKE% -DCMAKE_BUILD_TYPE=%BUILD_TYPE% -DCMAKE_INSTALL_PREFIX=%BASE_DIR%\bin -DBUILD_TESTING=OFF %BASE_DIR%\src\clapack
%BUILD_TOOL% %BUILD_COMMAND%
%BUILD_TOOL% %INSTALL_COMMAND%

REM Build SBW
mkdir %BASE_DIR%\tmp\SBW
cd /d %BASE_DIR%\tmp\SBW
%CMAKE% -DWITH_BUILD_BROKER=OFF -DWITH_BUILD_SHARED=OFF -DCMAKE_BUILD_TYPE=%BUILD_TYPE%  -DCMAKE_INSTALL_PREFIX=%BASE_DIR%\bin %BASE_DIR%\src\core
%BUILD_TOOL% %BUILD_COMMAND%
%BUILD_TOOL% %INSTALL_COMMAND%

REM Build CPP Unit
cd /d %BASE_DIR%
mkdir %BASE_DIR%\tmp\cppunit
cd /d %BASE_DIR%\tmp\cppunit
%CMAKE% -DCMAKE_BUILD_TYPE=%BUILD_TYPE%  -DCMAKE_INSTALL_PREFIX=%BASE_DIR%\bin %BASE_DIR%\src\cppunit
%BUILD_TOOL% %BUILD_COMMAND%
%BUILD_TOOL% %INSTALL_COMMAND%

REM Build Expat
cd /d %BASE_DIR%
mkdir %BASE_DIR%\tmp\expat
cd /d %BASE_DIR%\tmp\expat
%CMAKE% -DCMAKE_BUILD_TYPE=%BUILD_TYPE%  -DCMAKE_INSTALL_PREFIX=%BASE_DIR%\bin -DBUILD_shared=OFF -DBUILD_tests=OFF -DBUILD_tools=OFF -DBUILD_examples=OFF %BASE_DIR%\src\expat
%BUILD_TOOL% %BUILD_COMMAND%
%BUILD_TOOL% %INSTALL_COMMAND%

REM Build libSBML
cd /d %BASE_DIR%
mkdir %BASE_DIR%\tmp\libsbml
cd /d %BASE_DIR%\tmp\libsbml
%CMAKE% -DCMAKE_BUILD_TYPE=%BUILD_TYPE%  -DCMAKE_INSTALL_PREFIX=%BASE_DIR%/bin -DLIBSBML_USE_LEGACY_MATH=ON -DENABLE_COMP=ON -DENABLE_LAYOUT=ON -DENABLE_REQUIREDELEMENTS=OFF -DENABLE_RENDER=ON -DENABLE_COMP=ON -DENABLE_FBC=OFF -DENABLE_SPATIAL=OFF -DENABLE_GROUPS=OFF -DWITH_EXPAT=ON -DWITH_LIBXML=OFF -DLIBSBML_DEPENDENCY_DIR=%BASE_DIR%\bin -DLIBSBML_SKIP_SHARED_LIBRARY=ON -DWITH_BZIP2=OFF -DWITH_ZLIB=OFF -DENABLE_UNIVERSAL=ON %BASE_DIR%/src/libSBML
%BUILD_TOOL% %BUILD_COMMAND%
%BUILD_TOOL% %INSTALL_COMMAND%

REM build libSEDML
cd /d %BASE_DIR%
mkdir %BASE_DIR%\tmp\libSEDML
cd /d %BASE_DIR%\tmp\libSEDML
%CMAKE%  -DCMAKE_BUILD_TYPE=%BUILD_TYPE%  -DCMAKE_INSTALL_PREFIX=%BASE_DIR%/bin -DLIBSBML_STATIC=ON -DLIBSEDML_SHARED_VERSION=OFF -DLIBSEDML_SKIP_SHARED_LIBRARY=ON  -DLIBSEDML_DEPENDENCY_DIR=%BASE_DIR%/bin -DEXTRA_LIBS=%BASE_DIR%/lib/expat.lib %BASE_DIR%/src/libSEDML
%BUILD_TOOL% %BUILD_COMMAND%
%BUILD_TOOL% %INSTALL_COMMAND%

REM Build Raptor
cd /d %BASE_DIR%
mkdir %BASE_DIR%\tmp\raptor
cd /d %BASE_DIR%\tmp\raptor
%CMAKE% -DCMAKE_BUILD_TYPE=%BUILD_TYPE%  -DCMAKE_INSTALL_PREFIX=%BASE_DIR%\bin %BASE_DIR%\src\raptor
%BUILD_TOOL% %BUILD_COMMAND%
%BUILD_TOOL% %INSTALL_COMMAND%

REM mml
cd /d %BASE_DIR%
mkdir %BASE_DIR%\tmp\mml
cd /d %BASE_DIR%\tmp\mml
%CMAKE% -DCMAKE_BUILD_TYPE=%BUILD_TYPE%  -DCMAKE_INSTALL_PREFIX=%BASE_DIR%\bin %BASE_DIR%\src\mml
%BUILD_TOOL% %BUILD_COMMAND%
%BUILD_TOOL% %INSTALL_COMMAND%

REM Build QWT
cd /d %BASE_DIR%
mkdir %BASE_DIR%\tmp\qwt
cd /d %BASE_DIR%\tmp\qwt
%CMAKE% -DCMAKE_BUILD_TYPE=%BUILD_TYPE%  -DCMAKE_INSTALL_PREFIX=%BASE_DIR%\bin %BASE_DIR%\src\qwt
%BUILD_TOOL% %BUILD_COMMAND%
%BUILD_TOOL% %INSTALL_COMMAND%

REM Build QWT Plot
cd /d %BASE_DIR%
mkdir %BASE_DIR%\tmp\qwtplot3d
cd /d %BASE_DIR%\tmp\qwtplot3d
%CMAKE% -DCMAKE_BUILD_TYPE=%BUILD_TYPE%  -DCMAKE_INSTALL_PREFIX=%BASE_DIR%\bin %BASE_DIR%\src\qwtplot3d-qt4
%BUILD_TOOL% %BUILD_COMMAND%
%BUILD_TOOL% %INSTALL_COMMAND%

REM copy PDBs
cd /d %BASE_DIR%

xcopy /y /s %BASE_DIR%\tmp\clapack\BLAS\SRC\*.pdb %BASE_DIR%\bin\lib
xcopy /y /s %BASE_DIR%\tmp\clapack\F2CLIBS\libf2c\*.pdb %BASE_DIR%\bin\lib
xcopy /y /s %BASE_DIR%\tmp\libsbml\src\*.pdb %BASE_DIR%\bin\lib
xcopy /y /s %BASE_DIR%\tmp\cppunit\*.pdb %BASE_DIR%\bin\lib
xcopy /y /s %BASE_DIR%\tmp\expat\*.pdb %BASE_DIR%\bin\lib
xcopy /y /s %BASE_DIR%\tmp\raptor\*.pdb %BASE_DIR%\bin\lib
xcopy /y /s %BASE_DIR%\tmp\mml\*.pdb %BASE_DIR%\bin\lib
xcopy /y /s %BASE_DIR%\tmp\qwt\*.pdb %BASE_DIR%\bin\lib
xcopy /y /s %BASE_DIR%\tmp\qwtplot3d\*.pdb %BASE_DIR%\bin\lib
xcopy /y /s %BASE_DIR%\tmp\SBW\SBWCore\*.pdb %BASE_DIR%\bin\lib
xcopy /y /s %BASE_DIR%\tmp\SBW\SBWBroker\*.pdb %BASE_DIR%\bin\lib

cd /d %BASE_DIR%
