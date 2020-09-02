func PredictTheWinner(nums []int) bool {
    return total(nums, 0, len(nums) - 1, 1) >= 0
}

func total(nums []int, start, end int, turn int) int {
    if start == end {
        return nums[start] * turn
    }
    scoreStart := nums[start] * turn + total(nums, start + 1, end, -turn)
    scoreEnd := nums[end] * turn + total(nums, start, end - 1, -turn)
    return max(scoreStart * turn, scoreEnd * turn) * turn
}

func max(x, y int) int {
    if x > y {
        return x
    }
    return y
}
