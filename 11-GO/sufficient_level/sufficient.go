package main

import("fmt" 
"strings"
"sort")

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
   var max_occurence int = 0
	 var temporary_string string
   words := strings.Fields(str)
   wordCount := make(map[string]int)
   for i := range words {
        wordCount[words[i]]++
    }
        
    for key, value := range wordCount{
	 if value >= max_occurence {
	 	max_occurence = value
	 	temporary_string += " " + key
	 	}
    }
    result := strings.Fields(temporary_string)
    sort.Strings(result)
    return result[0]

	//return "a"
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

func FibRecursion(n int) int {
    if n <= 1 {
        return n
    }
    return FibRecursion(n-1) + FibRecursion(n-2)
}


func fib(nums []int) int {
	var fib_sum int = 0
	for i := 0; i < len(nums); i++ {
		fib_sum = fib_sum + FibRecursion(nums[i])
	}
	return fib_sum
}

func main() {
	//performTests()
  fmt.Println(palindrome("abba")) // true
  fmt.Println(palindrome("kayak")) // true
  fmt.Println(palindrome("sample")) // false

  fmt.Println(wordcount("word test word")) // "word"
  fmt.Println(wordcount("a a b g e ab e e a")) // "a"
	
  fmt.Println(rotate([]int{1, 2, 3, 4})) // [2 3 4 1]; rotated by 1
  fmt.Println(rotate([]int{5, 3, 20, 1, 2})) // [5 3 20 1 2]; rotated by 5

  fmt.Println(fib([]int{1, 2, 3})) // 4; explenation: 1 => 1, 2 => 1, 3 => 2, their sum = 4
  fmt.Println(fib([]int{1, 2, 8})) // 24; explenation: 1 => 1, 2 => 1, 8 => 21, their sum = 24 // actually 23
}
