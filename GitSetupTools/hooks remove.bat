@ECHO off

SET hookToRemove=..\.git\hooks\pre-commit

if not exist %hookToRemove% (
    echo The specified file does not exist.
    pause
)

if exist %hookToRemove% (
    del %hookToRemove%
    
    if not exist %hookToRemove% (
        echo The file has been successfully deleted.
        pause
    )

    if exist %hookToRemove% (
        echo Could not remove the file. Please, do it manually.
        pause
    )
)