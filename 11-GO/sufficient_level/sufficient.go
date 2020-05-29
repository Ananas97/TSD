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
	return []int{4, 1, 2, 3}
}

func fib(nums []int) int {
	return 4
}

func main() {
	//performTests()
  fmt.Println(palindrome("abba")) // true
  fmt.Println(palindrome("kayak")) // true
  fmt.Println(palindrome("sample")) // false
}
