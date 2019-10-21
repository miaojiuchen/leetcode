package trie

import (
	"fmt"
	"testing"
)

func Test_1032(t *testing.T) {
	Test_1032_1(t)
}

func Test_1032_1(t *testing.T) {
	sc := NewStreamChecker([]string{"abaa", "abaab", "aabbb", "bab", "ab"})
	fmt.Println(sc.Query('a'), false)
	fmt.Println(sc.Query('a'), false)
	fmt.Println(sc.Query('b'), true)
	fmt.Println(sc.Query('b'), false)
	fmt.Println(sc.Query('b'), true)

	fmt.Println(sc.Query('a'), true)
	fmt.Println(sc.Query('a'), false)
	fmt.Println(sc.Query('b'), false)
	fmt.Println(sc.Query('b'), false)
	fmt.Println(sc.Query('a'), false)
	fmt.Println(sc.Query('a'), false)
}

func Test_1032_2(t *testing.T) {
	sc := NewStreamChecker([]string{
		"aaaabbbaabbbabababaabababaabbaabbbaabbbbaabaabbbaaababbabbbbbaaabbaaabbaaabbaabbaaabbaaaaabaabbaaaba",
		"baababbaabbabbbbbbabbbaaabbbbaaabaabbbaaababbaaaaaababaaabbbbbbaabbbbbabbbaaabaaabbaababaaabbbbabaaabbbabaababaabbbbabbabbaaaaa",
		"abbbbbaababbaaabbaababaabbbabbbbbaaababaabbbabbbbbaabaaabababbaaabbbaaabbabbaaaaabbaaaaaaaaababbabbaaba",
		"aabaaaabaaaabbaaaababbaaabbabaabaaababaabbbabbaabbbabbbabbabaabbbaaabaaaabbabbabaabababaabbaabaaaabbababbaaababbbababbbbbbbaabab",
		"aaaaabaaaabaababbbababaabababbaaaaabbabaaaabababaaabbaabaababbbbbaabaabababbbaaaaaabaababbbbaabababaabbbbbabababaababbabababbbabaabaaababbaabbbabbaaaaabbaaaababbaabaaaabbababbbbaabbab",
		"bababbbbababaaaaaaabaabbabbaabababaaababbabaabbaabbbbbaaababbbaaaaaaabbbbaaaaababbbabbabababaabbabbabbabbbaabbabbabbbbbbabababbbabbabbabbaabbbbaaaaaaabaa",
	})
	fmt.Println(sc.Query('a'), false)
	fmt.Println(sc.Query('a'), false)
	fmt.Println(sc.Query('b'), true)
	fmt.Println(sc.Query('b'), false)
	fmt.Println(sc.Query('b'), true)

	fmt.Println(sc.Query('a'), true)
	fmt.Println(sc.Query('a'), false)
	fmt.Println(sc.Query('b'), false)
	fmt.Println(sc.Query('b'), false)
	fmt.Println(sc.Query('a'), false)
	fmt.Println(sc.Query('a'), false)
}
