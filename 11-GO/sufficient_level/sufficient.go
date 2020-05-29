package main

import("fmt")

func reverse_string(s string) (result string) {
   for _, v := range s {
      result = string(v) + result
   }
   return
}

func palindrome(str string) bool {
     if str == reverse_string(str) {
      return true
   }
	return false
}

func wordcount(str string) string {
	return "a"
}

func rotate(numbers []int) []int {
   var newArray []int
   var k int = numbers[0]
    for i:=0;i<k;i++{
        newArray = numbers[1:len(numbers)]
        newArray = append(newArray,numbers[0])
        numbers = newArray
    }

    return numbers

//	return []int{4, 1, 2, 3}
}


func fib(nums []int) int {
	return 4
}

func main() {
	//performTests()
  fmt.Println(palindrome("abba")) // true
  fmt.Println(palindrome("kayak")) // true
  fmt.Println(palindrome("sample")) // false
	
  fmt.Println(rotate([]int{1, 2, 3, 4})) // [2 3 4 1]; rotated by 1
  fmt.Println(rotate([]int{5, 3, 20, 1, 2})) // [5 3 20 1 2]; rotated by 5
}
