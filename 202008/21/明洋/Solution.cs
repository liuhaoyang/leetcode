/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
 public class Solution
{
    public int MinDepth(TreeNode root)
    {
        if (root == null) return 0;

        if (root.left == null && root.right == null) return 1;

        var depth = int.MaxValue;
        if (root.left!= null)
        {
            depth = Math.Min(MinDepth(root.left), depth);
        }
        if (root.right != null)
        {
            depth = Math.Min(MinDepth(root.right), depth);
        }
        return depth + 1;
    }
}