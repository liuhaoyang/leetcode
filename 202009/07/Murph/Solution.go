func topKFrequent(nums []int, k int) []int {

	var tempMap = make(map[int]int)
	var n = make([]int, 0)
	for _, v := range nums {
		if i, ok := tempMap[v]; ok {
			tempMap[v] = i + 1
		} else {
			tempMap[v] = 1
			n = append(n, v)
		}
	}

	sort.Slice(n, func(i, j int) bool {
		return tempMap[n[i]] > tempMap[n[j]]
	})

	return n[:k]
}