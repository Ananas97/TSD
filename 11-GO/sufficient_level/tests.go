package main

import "fmt"

const (
	PassingColor  = "\033[1;34mPASSING\033[0m"
	ErrorColor    = "\033[1;31mFAILED\033[0m"
	WellDoneColor = "\033[1;34mWELL DONE!\033[0m"
)

func runTaskTest(fn func(interface{}) interface{}, testInputs []interface{}, testOutputs []interface{}, taskName string) (int, int) {
	fmt.Println("======= ", taskName, "\t Running tests =======")
	var passing, failed int = 0, 0
	for index, s := range testInputs {
		var result = fn(s)
		fmt.Print(s, " \t=>\t", result, "\t")
		passed := true
		resultSlice, ok := result.([]int)
		expectedSlice, ok2 := testOutputs[index].([]int)
		if ok && ok2 { // if we are comparing arrays
			for j, el := range resultSlice {
				if el != expectedSlice[j] {
					passed = false
					break
				}
			}
		} else { // if we are comparing primitive types
			if result != testOutputs[index] {
				passed = false
			}
		}
		if passed {
			fmt.Println(PassingColor)
			passing++
		} else {
			fmt.Println(ErrorColor, "expected: ", testOutputs[index])
			failed++
		}
	}
	fmt.Println("Tests passed: ", passing, "/", passing+failed)
	fmt.Print("Result: ")
	if failed == 0 {
		fmt.Println(WellDoneColor)
	} else {
		fmt.Println(ErrorColor)
	}
	return passing, failed
}

// wrapping function that returns a string
// in one that returns empty interface
// so as to sidestep Go's lack of generic types
func task1runner(s interface{}) interface{} {
	str, ok := s.(string)
	if !ok {
		return false
	}
	return palindrome(str)
}

func task2runner(s interface{}) interface{} {
	str, ok := s.(string)
	if !ok {
		return false
	}
	return wordcount(str)
}

func task3runner(s interface{}) interface{} {
	slice, ok := s.([]int)
	if !ok {
		return false
	}
	return rotate(slice)
}

func task4runner(n interface{}) interface{} {
	nn, ok := n.([]int)
	if !ok {
		return false
	}
	return fib(nn)
}

func performTests() {
	var passing, failed int = 0, 0

	//task 1
	testStrings := []interface{}{"wow", "much", "pallap", "kayak", "oo", ""}
	expectedValues := []interface{}{true, false, true, true, true, true}
	var p, f int = runTaskTest(task1runner, testStrings, expectedValues, "1. Palindrome")
	passing += p
	failed += f

	//task 2
	testTexts := []interface{}{"word test word", "a a b g e ab e e a", "test", "lorem ipsum 48 _ 23 lorem"}
	expectedWords := []interface{}{"word", "a", "test", "lorem"}
	p, f = runTaskTest(task2runner, testTexts, expectedWords, "2. Word count")
	passing += p
	failed += f

	//task 3
	tesetSlices := []interface{}{[]int{1, 2, 3, 4}, []int{5, 3, 20, 1, 2}, []int{9, 6, 1, 1, 2}, []int{90000000, 2, 1}}
	expectedSlices := []interface{}{[]int{4, 1, 2, 3}, []int{5, 3, 20, 1, 2}, []int{6, 1, 1, 2, 9}, []int{90000000, 2, 1}}
	p, f = runTaskTest(task3runner, tesetSlices, expectedSlices, "3. Rotate")
	passing += p
	failed += f

	//task 4
	testInts := []interface{}{[]int{1, 2, 3}, []int{2, 3, 8}, []int{0, 15, 15}, []int{20, 3, 1, 7}, []int{50, 50, 0, 0, 0}, []int{0, 0, 0, 0}}
	expectedInts := []interface{}{4, 24, 1220, 6781, 25172538050, 0}
	p, f = runTaskTest(task4runner, testInts, expectedInts, "4. Fibonacci")
	passing += p
	failed += f

	fmt.Println("======= \t RESULTS SUMMARY \t======")
	fmt.Println(PassingColor, ":\t", passing)
	fmt.Println(ErrorColor, ":\t", failed)
}
