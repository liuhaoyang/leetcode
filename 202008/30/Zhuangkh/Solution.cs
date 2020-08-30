public class Solution
{
    public string ReverseWords (string s)
    {
        string result = string.Empty;
        string[] str = s.Split (' ');
        for (int i = 0, ic = str.Length; i < ic; i++)
        {
            var array = str[i].ToCharArray ();
            Array.Reverse (array);
            result += new string (array) + (i == ic - 1 ? "" : " ");
        }
        return result;
    }
}
