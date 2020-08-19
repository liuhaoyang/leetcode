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
    public bool IsBalanced(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }

        if (IsBalanced(root.left) && IsBalanced(root.right))
        {
            int left = root.left == null ? 0 : CalcHeight(root.left);
            int right = root.right == null ? 0 : CalcHeight(root.right);

            return Math.Abs(left - right) <= 1;
        }

        return false;
    }

    public int CalcHeight(TreeNode node)
    {
        int left = 0, right = 0;

        if (node?.left != null)
        {
            left = CalcHeight(node.left);
        }

        if (node?.right != null)
        {
            right = CalcHeight(node.right);
        }

        return left > right ? left + 1 : right + 1;
    }
}