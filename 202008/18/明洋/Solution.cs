public class Solution
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            return BuildTree(head, null);
        }
        public TreeNode BuildTree(ListNode left, ListNode right)
        {
            if (left == right)
            {
                return null;
            }
            ListNode mid = GetMedian(left, right);
            TreeNode root = new TreeNode(mid.val);
            root.left = BuildTree(left, mid);
            root.right = BuildTree(mid.next, right);
            return root;
        }

        public ListNode GetMedian(ListNode left, ListNode right)
        {
            ListNode fast = left;
            ListNode slow = left;
            while (fast != right && fast.next != right)
            {
                fast = fast.next;
                fast = fast.next;
                slow = slow.next;
            }
            return slow;
        }
    }