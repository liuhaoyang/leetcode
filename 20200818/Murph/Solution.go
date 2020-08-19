/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val int
 *     Next *ListNode
 * }
 */
/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
 func sortedListToBST(head *ListNode) *TreeNode {
	return build(head, nil)
}

func build(left *ListNode, right *ListNode) *TreeNode {
	if left == right {
		return nil
	}

	mid := midFunc(left, right)
	root := &TreeNode{Val: mid.Val}
	root.Left = build(left, mid)
	root.Right = build(mid.Next, right)
	return root

}

func midFunc(left *ListNode, right *ListNode) *ListNode {
	fast := left
	last := left

	for fast != right && fast.Next != right {
		fast = fast.Next.Next
		last = last.Next
	}
	return last

}