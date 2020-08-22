public class Solution
{
    public int MinDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int left = MinDepth(root.left);
        int right = MinDepth(root.right);

        return left == 0 ? right + 1 : right == 0 ? left + 1 : Math.Min(left, right) + 1;
    }
}