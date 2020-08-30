func rangeBitwiseAnd(m int, n int) int {
	var compareResult = m & n

	for i := n - 1; i >= m+1; i-- {
		compareResult = compareResult & i
		if compareResult == 0 {
			return compareResult
		}
	}

	return compareResult
}