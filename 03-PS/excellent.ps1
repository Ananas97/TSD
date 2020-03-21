# task  1
$array = foreach($i in 1..10000) { 
  Get-Random
}
Measure-Command {$array | Sort-Object} | Select-Object -Property TotalSeconds
$DOTnet = New-Object System.Collections.ArrayList
 foreach($i in $array.Length) { 
  $DOTnet.Add([int]$array[$i])
}
Measure-Command {$DOTnet.Sort()} | Select-Object -Property TotalSeconds
