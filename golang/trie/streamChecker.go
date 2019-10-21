package trie

type StreamChecker struct {
	t     Trie
	chars []byte
}

func NewStreamChecker(words []string) StreamChecker {
	trie := NewTrie()
	for _, w := range words {
		trie.Insert(w)
	}

	return StreamChecker{
		t: trie,
	}
}

func (sc *StreamChecker) Query(letter byte) bool {
	sc.chars = append(sc.chars, letter)
	charCount := len(sc.chars)
	maxLen := sc.t.MaxLength()
	for i := 1; i <= maxLen; i++ {
		if i > charCount {
			break
		}
		start := charCount - i

		word := string(sc.chars[start:])

		if sc.t.Search(word) {
			return true
		}
	}
	return false
}
