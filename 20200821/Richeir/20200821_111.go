func minDepth(root *TreeNode) int {

	if root == nil {
		return 0
	}
	resultLeft := 0
	resultRight := 0
	if root.Left != nil {
		resultLeft = CheckNode111(root.Left)
		if root.Right == nil {
			return resultLeft + 1
		}
	}

	if root.Right != nil {
		resultRight = CheckNode111(root.Right)
		if root.Left == nil {
			return resultRight + 1
		}
	}

	if resultLeft < resultRight {
		return resultLeft + 1
	} else {
		return resultRight + 1
	}
}

func CheckNode111(node *TreeNode) int {
	deepL := 0
	deepR := 0

	if node.Left != nil {
		deepL += CheckNode111(node.Left)
	}

	if node.Right != nil {
		deepR += CheckNode111(node.Right)
	}

	//叶子节点处理
	if node.Left == nil && node.Right == nil {
		return 1
	}

	if node.Left != nil && node.Right != nil {
		if deepL < deepR {
			return deepL + 1
		}
		return deepR + 1
	} else if node.Left != nil && node.Right == nil {
		return deepL + 1
	} else {
		return deepR + 1
	}
}