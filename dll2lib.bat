@echo off
rem see http://stackoverflow.com/questions/9946322/how-to-generate-an-import-library-lib-file-from-a-dll#9946390

rem see also http://www.postgresql-archive.org/MSVC-pl-perl-error-message-is-not-verbose-enough-td5913411.html
rem see also  https://postgr.es/m/CABcP5fjEjgOsh097cWnQrsK9yCswo4DZxp-V47DKCH-MxY9Gig@mail.gmail.com

rem modified from https://gist.github.com/adunstan/7bc0fcb83d60002092e66a4adec7ea35

REM Usage: dll2lib [32|64] some-file.dll
REM
REM Generates some-file.lib from some-file.dll, making an intermediate
REM some-file.def from the results of dumpbin /exports some-file.dll.
REM Currently must run without path on DLL.
REM (Fix by removing path when of lib_name for LIBRARY line below?)
REM
REM Requires 'dumpbin' and 'lib' in PATH - run from VS developer prompt.
REM 
REM Script inspired by http://stackoverflow.com/questions/9946322/how-to-generate-an-import-library-lib-file-from-a-dll
SETLOCAL
if "$1"=="32" (set machine=x86) else (set machine=x64)
set dll_file=%2
set dll_file_no_ext=%dll_file:~0,-4%
set exports_file=%dll_file_no_ext%-exports.txt
set def_file=%dll_file_no_ext%.def
set lib_file=%dll_file_no_ext%.lib
set lib_name=%dll_file_no_ext%

dumpbin /exports %dll_file% > %exports_file%

echo LIBRARY %lib_name% > %def_file%
echo EXPORTS >> %def_file%
for /f "skip=19 tokens=1,4" %%A in (%exports_file%) do if NOT "%%B" == "" (echo %%B @%%A >> %def_file%)

lib /def:%def_file% /out:%lib_file% /machine:%1

REM Clean up temporary intermediate files
del %exports_file% %def_file% %dll_file_no_ext%.exp