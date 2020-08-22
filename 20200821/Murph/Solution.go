func minDepth(root *TreeNode) int {
	if root == nil {
		return 0
	}
	return getMin(root)
}

func min(x int, y int) int {
	if x < y {
		return x
	}
	return y
}

func getMin(node *TreeNode) int {

	if node.Left == nil && node.Right == nil {
		return 1
	}

	minTT := 99999

	if node.Left != nil {
		minTT = min(minTT, getMin(node.Left))
	}

	if node.Right != nil {
		minTT = min(minTT, getMin(node.Right))
	}

	return minTT + 1

}