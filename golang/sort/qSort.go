package sort

import (
	"fmt"
)

func Test_QSort() {
	arr := []int{13, 4, 7, 9, 2, 8, 10}
	QSort(arr, 0, len(arr)-1)
	fmt.Println(arr)
}

func QSort(arr []int, start, end int) {
	fmt.Println("\nqSort", start, end)
	if start >= end {
		return
	}

	i, j := start, end
	key := arr[(start+end)/2]

	for i <= j {
		for arr[i] < key {
			i++
		}

		for arr[j] > key {
			j--
		}

		if i <= j {
			arr[i], arr[j] = arr[j], arr[i]
			fmt.Println(arr, i, j)
			i++
			j--
		}
	}

	if start < j {
		QSort(arr, start, j)
	}

	if end > i {
		QSort(arr, i, end)
	}
}
