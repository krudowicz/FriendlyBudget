@ECHO off

SET sourcePath=hooks\pre-commit
SET targetPath=..\.git\hooks
SET finalFilePath=..\.git\hooks\pre-commit

xcopy %sourcePath% %targetPath%

SET finalFilePath = ..\.git\hooks\pre-commit

if exist %finalFilePath% (
	echo File has been copied successfully.
	pause 
	) 

if not exist %finalFilePath% (
	echo An error occurred. File has not been copied.
	pause
)