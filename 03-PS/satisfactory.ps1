# task 5
$chfeed = [xml](Invoke-WebRequest "https://sleepy-wilson-d2b50e.netlify.com/powershell/PowerShell.rss")
$chfeed.rss.channel.item | Select-Object title


# task 1
Get-Process | Select-Object CPU, ProcessName | Where-Object { $_.CPU -gt 10 }> C:\Users\Ananas\Desktop\OUTPUT.txt

# task3
$file = Invoke-WebRequest -Uri https://sleepy-wilson-d2b50e.netlify.com/powershell/MSDN.txt
$file.Content | findstr "PowerShell"
#number of line is missing