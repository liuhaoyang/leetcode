public class Solution {
    public bool IsValid (string s) {
        if (s.Length == 0) return true;
        if (s.Length % 2 == 1) return false;
        var dic = new Dictionary<char, char> ();
        dic.Add (']', '[');
        dic.Add ('}', '{');
        dic.Add (')', '(');
        var stack = new Stack ();
        for (var i = 0; i < s.Length; i++) {
            var temp = s[i];

            if (dic.TryGetValue (temp, out var value)) {
                if (stack.Count == 0) return false;
                if (!Convert.ToChar (stack.Pop ()).Equals (value)) return false;
                if (stack.Count == 0) return true;
            } else {
                stack.Push (temp);
            }
        }
        return false;
    }
}