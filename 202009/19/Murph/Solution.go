func sumOfLeftLeaves(root *TreeNode) int {
	if root == nil {
		return 0
	}
	value := sumOfLeftLeaves(root.Left) + sumOfLeftLeaves(root.Right)
	if root.Left != nil && root.Left.Left == nil && root.Left.Right == nil {
		return value + root.Left.Val
	}
	return value
}