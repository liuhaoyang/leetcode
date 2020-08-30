public class Solution {
    public string ShortestPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
        int index = right;

        while (right > left)
        {
            if (s[left] == s[right])
            {
                left++;
                right--;
            }
            else
            {
                left = 0;
                right = index - 1;
                index = right;
            }
        }

        var strArr = s.Substring(index + 1, s.Length - (index + 1)).Reverse().ToArray();
        var str = string.Join("", strArr);

        return str + s;
    }
}