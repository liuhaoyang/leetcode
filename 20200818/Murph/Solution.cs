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
    public class Solution
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            return build(head, null);

            TreeNode build(ListNode left, ListNode right)
            {
                if (left == right) return null;

                var mid = midFunc(left, right);
                var temp = new TreeNode(mid.val);
                temp.left = build(left, mid);
                temp.right = build(mid.next, right);
                return temp;
            }

            ListNode midFunc(ListNode left, ListNode right)
            {
                var fast = left;
                var last = left;
                while (fast != right && fast.next != right)
                {
                    fast = fast.next;
                    fast = fast.next;
                    last = last.next;
                }

                return last;
            }
        }
    }