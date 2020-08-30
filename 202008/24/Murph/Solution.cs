public class Solution {
        public bool RepeatedSubstringPattern(string s)
        {
            if (s == null || s.Length <=0) return false;
            return (s + s).IndexOf(s, 1) != s.Length;
        }
}