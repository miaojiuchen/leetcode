package main

func fraction(cont []int) []int {
	length := len(cont)
	if length == 1 {
		return []int{cont[0], 1}
	}

	base := cont[length-1] // 分母
	molecule := 1          // 分子

	for i := length - 2; i >= 0; i-- {
		molecule = cont[i]*base + molecule
		base, molecule = molecule, base
	}

	// 最后需要反序
	return []int{base, molecule}
}
