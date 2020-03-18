#task 1
#implementation
function Multiply ($a, $b)
{
return $a * $b
}
#invocation
Multiply 2 4
Multiply -a 5 -b 2
#task 2
#implementation
function Increment 
{
Param
([Parameter(Mandatory=$true,Position=0)]
[int]$number,
[Parameter(Mandatory=$false, Position=1)]
[int]$incrementValue=1)

return $number + $incrementValue;
}
#invocation
Increment 2 5 
Increment 3    
Increment 
#task 3
#implementation
Get-Date -f "dddd, MMMM dd, yyy"
#task 5
#implementation
Get-ChildItem  | Sort-Object -Property Name | Format-Table Name, Length
#task 7
#implementation
Get-ChildItem -Recurse  | Where-Object -FilterScript {($_.Length -ge 1mb)}
#task 8
Get-ChildItem  | Select-Object Name, Length |Sort-Object -Property Name |Out-GridView
