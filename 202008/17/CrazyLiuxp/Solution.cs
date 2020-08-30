public class Solution {
    public bool IsBalanced(TreeNode root)
    {
        return height(root) != -1;
    }

    private int height(TreeNode root)
    {
        if (root == null) return 0;

        int leftHeight, rightHeight;
        if ((leftHeight = height(root.left)) == -1 || (rightHeight = height(root.right)) == -1 || Math.Abs(leftHeight - rightHeight) > 1)
        {
            return -1;
        }

        return Math.Max(leftHeight, rightHeight) + 1;
    }
}