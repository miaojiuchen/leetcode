package main

import (
	"math"
	"strings"
)

func robot(command string, obstacles [][]int, x int, y int) bool {
	// 过滤不可能的障碍点
	nobstacles := [][]int{}
	for _, o := range obstacles {
		if o[0] <= x && o[1] <= y {
			nobstacles = append(nobstacles, []int{o[0], o[1]})
		}
	}

	cmd := strings.Split(command, "")

	// 计算一趟cmd后，x和y的位移的值
	xStep := 0
	yStep := 0
	for _, c := range cmd {
		if c == "R" {
			xStep++
		}
		if c == "U" {
			yStep++
		}
	}

	// 对每一个障碍点，计算是否在路径上
	for _, o := range nobstacles {
		if willBroken(o, xStep, yStep, cmd) {
			return false
		}
	}

	if willBroken([]int{x, y}, xStep, yStep, cmd) {
		return true
	}

	return false
}

func willBroken(obstacle []int, xStep, yStep int, cmd []string) bool {
	x, y := obstacle[0], obstacle[1]

	if xStep == 0 {
		return x == 0
	}
	if yStep == 0 {
		return y == 0
	}

	xCount := x / xStep
	yCount := y / yStep

	if xCount != yCount && absSub(xCount, yCount) != 1 {
		return false
	}

	baseCount := xCount
	if baseCount > yCount {
		baseCount = yCount
	}

	baseX := baseCount * xStep
	baseY := baseCount * yStep

	if baseX == x && baseY == y {
		return true
	}

	for _, c := range cmd {
		if c == "R" {
			baseX++
		}
		if c == "U" {
			baseY++
		}
		if baseX == x && baseY == y {
			return true
		}
	}

	return false
}

func absSub(a, b int) int {
	return int(math.Abs(float64(a - b)))
}
