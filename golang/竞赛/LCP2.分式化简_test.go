package main

import (
	"fmt"
	"testing"
)

func Test_fraction(t *testing.T) {
	fmt.Println(fraction([]int{1, 3}))
	fmt.Println(fraction([]int{3, 2, 0, 2}))

	fmt.Println(fraction([]int{0, 0, 3}))

	fmt.Println(fraction([]int{3, 2, 1, 2}))
}
