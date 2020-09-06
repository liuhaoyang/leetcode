public class Solution
{
    public IList<IList<int>> LevelOrderBottom (TreeNode root)
    {
        List<IList<int>> result = new List<IList<int>> ();
        LevelOrderBottom (result, root, 0);
        result.Reverse ();
        return result;
    }

    public void LevelOrderBottom (List<IList<int>> result, TreeNode node, int index)
    {
        if (node != null)
        {
            if (result.Count () > index)
            {
                result[index].Add (node.val);
            }
            else
            {
                result.Add (new List<int> () { node.val });
            }
            LevelOrderBottom (result, node.left, index + 1);
            LevelOrderBottom (result, node.right, index + 1);
        }
    }

}
