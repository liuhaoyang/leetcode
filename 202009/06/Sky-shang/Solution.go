func levelOrderBottom(root *TreeNode) [][]int {
    levelOrder := [][]int{}
    if root == nil {
        return levelOrder
    }
    queue := []*TreeNode{}
    queue = append(queue, root)
    for len(queue) > 0 {
        level := []int{}
        size := len(queue)
        for i := 0; i < size; i++ {
            node := queue[0]
            queue = queue[1:]
            level = append(level, node.Val)
            if node.Left != nil {
                queue = append(queue, node.Left)
            }
            if node.Right != nil {
                queue = append(queue, node.Right)
            }
        }
        levelOrder = append(levelOrder, level)
    }
    for i := 0; i < len(levelOrder) / 2; i++ {
        levelOrder[i], levelOrder[len(levelOrder) - 1 - i] = levelOrder[len(levelOrder) - 1 - i], levelOrder[i]
    }
    return levelOrder
}