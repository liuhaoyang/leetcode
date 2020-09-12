type data struct{ sum, count int }

func averageOfLevels(root *TreeNode) []float64 {
	levelData := []data{}
	var dfs func(node *TreeNode, level int)
	dfs = func(node *TreeNode, level int) {
		if node == nil {
			return
		}
		if level < len(levelData) {
			levelData[level].sum += node.Val
			levelData[level].count++
		} else {
			levelData = append(levelData, data{node.Val, 1})
		}
		dfs(node.Left, level+1)
		dfs(node.Right, level+1)
	}
	dfs(root, 0)

	averages := make([]float64, len(levelData))
	for i, d := range levelData {
		averages[i] = float64(d.sum) / float64(d.count)
	}
	return averages
}
