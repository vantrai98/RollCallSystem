robocopy ".\src\Contents" ".\dist\Contents" /S /E /nfl /ndl /njh /njs
robocopy ".\src\assets" ".\dist\assets" /S /E /nfl /ndl /njh /njs
robocopy ".\dist" "..\RCS.Web\dist" /S /E /nfl /ndl /njh /njs
EXIT 0

