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
