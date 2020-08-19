public class Solution {
    public int CountSubstrings(string s)
    {
        int num = 0;
        for(int i = 0; i < s.Length; i++)
        {
            Count(s, i, i, ref num);
            Count(s, i, i + 1, ref num);
        }

        return num;
    }

    private void Count(string s, int left, int right, ref int num)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            num++;
            left--;
            right++;
        }
    }
}