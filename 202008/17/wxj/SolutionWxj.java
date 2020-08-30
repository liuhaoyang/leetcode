/**
 * Definition for a binary tree node.
 *
 */
public class TreeNode {
     int val;
     TreeNode left;
     TreeNode right;
     TreeNode(int x) { val = x; }
 }
class Solution {
    public boolean isBalanced(TreeNode root) {
        if(root == null) {
            return false;
        }
        return dataDeph(root) >= 0 ? true:false;

    }

    private int dataDeph(TreeNode root){
        if(root == null) return 0;
        int leftDeph = dataDeph(root.left);
        int rightDeph = dataDeph(root.right);
        if(leftDeph < 0 || rightDeph < 0 || Math.abs(leftDeph - rightDeph) >1){
            return -1;
        }
        return Math.max(leftDeph,rightDeph) +1;
    }
}