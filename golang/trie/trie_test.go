package trie

import (
	"fmt"
	"testing"
)

func Test_208(t *testing.T) {
	trie := NewTrie()
	trie.Insert("a")
	fmt.Println(trie.Search("a"), true)
	fmt.Println(trie.StartsWith("a"), true)

	trie.Insert("inf")
	trie.Insert("cool")
	trie.Insert("cola")

	trie.Insert("infinity")
	trie.Insert("infinsity")

	fmt.Println(trie.Search("infinity"), true)
	fmt.Println(trie.Search("infinit"), false)

	fmt.Println(trie.StartsWith("inf"), true)
	fmt.Println(trie.StartsWith("ina"), false)

	trie.Print()
}
