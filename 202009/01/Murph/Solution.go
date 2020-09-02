func PredictTheWinner(nums []int) bool {
	return 0 <= total(nums, 0, len(nums)-1, 1)
}

func max(x int, y int) int {
	if x > y {
		return x
	}
	return y
}
func total(nums []int, x int, y int, turn int) int {

	if x == y {
		return nums[x] * turn
	}

	left := nums[x]*turn + total(nums, x+1, y, -turn)
	right := nums[y]*turn + total(nums, x, y-1, -turn)

	return max(left*turn, right*turn) * turn
}
