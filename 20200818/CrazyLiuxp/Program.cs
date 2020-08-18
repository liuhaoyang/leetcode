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
    private ListNode gloabalhead;
    public TreeNode SortedListToBST(ListNode head) {
        gloabalhead = head;
        int length = GetLength(head);
        return BuildTree(0, length - 1);
    }

    private int GetLength(ListNode head)
    {
        int result = 0;
        while (head != null)
        {
            result++;
            head = head.next;
        }
        return result;
    }

    //中序遍历
    private TreeNode BuildTree(int left,int right)
    {
        if (left > right) return null;

        int mid = (left + right + 1) / 2;

        TreeNode root = new TreeNode();
        root.left = BuildTree(left, mid - 1);
        root.val = gloabalhead.val;
        gloabalhead = gloabalhead.next;
        root.right = BuildTree(mid + 1, right);

        return root;
    }
}