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
        return Height(root) >= 0;
    }

    // 返回当前根节点高度，如果有超出其高度平衡(1) 则返回-1
    public int Height(TreeNode root) 
    {
        if (root == null) return 0;
        
        int legtHeight = Height(root.left);
        int rightHeight = Height(root.right);

        if (legtHeight == -1 || rightHeight == -1 || Math.Abs(legtHeight - rightHeight) > 1)
        {
            return -1;
        }
        else
        {
            return Math.Max(legtHeight, rightHeight) + 1;
        }
    }
}