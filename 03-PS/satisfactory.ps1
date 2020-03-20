# task 5
$chfeed = [xml](Invoke-WebRequest "https://sleepy-wilson-d2b50e.netlify.com/powershell/PowerShell.rss")
$chfeed.rss.channel.item | Select-Object title
