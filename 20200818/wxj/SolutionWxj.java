
//  //Definition for singly-linked list.
  public class ListNode {
      int val;
      ListNode next;
      ListNode() {}
      ListNode(int val) { this.val = val; }
      ListNode(int val, ListNode next) { this.val = val; this.next = next; }
  }
//
// //Definition for a binary tree node.
  public class TreeNode {
      int val;
      TreeNode left;
      TreeNode right;
      TreeNode() {}
      TreeNode(int val) { this.val = val; }
      TreeNode(int val, TreeNode left, TreeNode right) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }

class Solution {
    public TreeNode sortedListToBST(ListNode head) {
        return buildTree(head,null);
    }

    public TreeNode buildTree (ListNode left,ListNode right){
        //if(left == right || left == null ){
        if (left == right) {
            return null;
        }
        ListNode mid = getMid(left,right);
        TreeNode treeNode = new TreeNode(mid.val);
        treeNode.left = buildTree(left,mid);
        treeNode.right = buildTree(mid.next,right);
        return treeNode;
    }
    public ListNode getMid (ListNode left,ListNode right){
        ListNode fast = left;
        ListNode slow = left;
        while(fast != right && fast.next != right){
            fast = fast.next;
            //if(fast != null){
                fast = fast.next;
           // }
            slow = slow.next;
            //if(fast == null){
            //    break;
            //}
        }
        return slow;
    }
}