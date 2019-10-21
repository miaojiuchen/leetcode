package trie

import (
	"fmt"
)

type Trie struct {
	m        map[byte]*Node
	maxdepth int
}

func NewTrie() Trie {
	return Trie{
		m:        make(map[byte]*Node),
		maxdepth: 0,
	}
}

/** Inserts a word into the trie. */
func (t *Trie) Insert(word string) {
	defer func() {
		if len(word) > t.maxdepth {
			t.maxdepth = len(word)
		}
	}()

	bytes := []byte(word)
	if len(word) == 0 {
		return
	}

	firstC := bytes[0]

	var cur *Node
	cur, ok := t.m[firstC]
	if !ok {
		t.m[firstC] = newNode(firstC, len(word) == 1, 0)
		cur = t.m[firstC]
	}

	for i := 1; i < len(bytes); i++ {
		b := bytes[i]
		end := i == len(bytes)-1
		if _, ok := cur.m[b]; !ok {
			cur.m[b] = newNode(b, end, i)
		}
		if end {
			cur.m[b].isWord = true
		}
		cur = cur.m[b]
	}
}

/** Returns if the word is in the trie. */
func (t *Trie) Search(word string) bool {
	if len(word) == 0 {
		return false
	}

	bytes := []byte(word)
	firstC := bytes[0]

	root, ok := t.m[firstC]
	if !ok {
		return false
	}

	cur := root

	for i := 1; i < len(bytes); i++ {
		b := bytes[i]
		if _, ok := cur.m[b]; !ok {
			return false
		}
		cur = cur.m[b]
	}

	return cur.isWord
}

/** Returns if there is any word in the trie that starts with the given prefix. */
func (t *Trie) StartsWith(prefix string) bool {
	if len(prefix) == 0 {
		return true
	}

	bytes := []byte(prefix)
	firstC := bytes[0]

	root, ok := t.m[firstC]
	if !ok {
		return false
	}

	cur := root

	for i := 1; i < len(bytes); i++ {
		b := bytes[i]
		if _, ok := cur.m[b]; !ok {
			return false
		}
		cur = cur.m[b]
	}

	return true
}

func (t *Trie) MaxLength() int {
	return t.maxdepth
}

type Node struct {
	m      map[byte]*Node
	b      byte
	isWord bool
	depth  int
}

func newNode(b byte, isWord bool, depth int) *Node {
	return &Node{
		isWord: isWord,
		m:      make(map[byte]*Node),
		b:      b,
	}
}

// Print 逐行打印树的每一层节点列表，单词尾会用{}包起来
func (t *Trie) Print() {
	depth := 0
	for {
		if depth == t.maxdepth {
			break
		}
		for _, n := range t.m {
			n.PrintNDepth(depth)
		}
		fmt.Println()
		depth++
	}
}

// Print 打印该节点下第 N 层所有节点
func (n *Node) PrintNDepth(depth int) {
	if depth == 0 {
		if n.isWord {
			fmt.Print("{")
		}
		fmt.Printf("%c", n.b)
		if n.isWord {
			fmt.Print("}")
		}

		fmt.Print(" ")
		return
	}
	for _, nn := range n.m {
		nn.PrintNDepth(depth - 1)
	}
}
