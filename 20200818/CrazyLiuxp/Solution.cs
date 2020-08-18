/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedListToBST(ListNode head)
    {
        if (head == null) return null;

        return BuildTree(head, null);
    }

    //方法1：快慢指针找中心节点
    private TreeNode BuildTree(ListNode start, ListNode end)
    {
        if (start == end) return null;

        ListNode fast = start, slow = start;

        while(fast!=end && fast.next != end)
        {
            fast = fast.next?.next;
            slow = slow.next;
        }

        TreeNode root = new TreeNode(slow.val);
        root.left = BuildTree(start, slow);
        root.right = BuildTree(slow.next, end);

        return root;
    }
}