@echo off
cd /d "%~dp0"
echo ===================================================
echo        DANG TU DONG UPDATE TAT CA PROJECT LEN GIT   
echo ===================================================
echo [*] Dang quet cac thay doi tu tat ca project con...
git add .
set "commit_message=Auto-update all projects: %date% %time%"
echo [*] Dang tao commit...
git commit -m "%commit_message%"
echo [*] Dang upload toan bo len GitHub...
git push -u origin main
echo ===================================================
echo [THANH CONG] Tat ca cac Project da duoc day len cung 1 Repo!
echo ===================================================
pause