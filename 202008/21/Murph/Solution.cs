/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int MinDepth (TreeNode root) {
        if (root == null) return 0;
        var minTemplate = min (root);
        return minTemplate;
        int min (TreeNode node) {
            if (node.left == null && node.right == null) return 1;

            int minTT = int.MaxValue;
            if (node.left != null) minTT = Math.Min (min (node.left), minTT);

            if (node.right != null) minTT = Math.Min (min (node.right), minTT);

            return minTT + 1;
        }

    }
}