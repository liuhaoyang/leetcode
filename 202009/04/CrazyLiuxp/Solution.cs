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
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        var result = new List<string>();
        if (root == null) return result;
        var currentPath = string.Empty;

        dfs(root, currentPath, result);

        return result;
    }

    private void dfs(TreeNode root, string currentPath, IList<string> result)
    {
        if (root == null) return;

        if(root.left==null && root.right == null)
        {
            result.Add(currentPath + root.val);
        }

        dfs(root.left, currentPath + root.val + "->", result);
        dfs(root.right, currentPath + root.val + "->", result);
    }
}