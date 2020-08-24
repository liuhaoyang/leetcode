public class Solution {
    public bool RepeatedSubstringPattern(string s)
    {
        return (s + s).Substring(1, (s + s).Length - 2).Contains(s);
    }
}