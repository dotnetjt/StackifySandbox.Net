$args >> output.txt
$key = $args[0]
$env = $args[1]
$storagedir = $pwd
$webclient = New-Object System.Net.WebClient
$url = "http://s1.stackify.com/Account/AgentDownload"
$file = "$storagedir\StackifyInstall.exe"
$webclient.DownloadFile($url,$file)
& $file /s /v"ACTIVATIONKEY=$key ENVIRONMENT=\`"$env\`" ENABLEPROFILER=1 RESTARTIIS=1 /qn /l*v .\Log.txt"