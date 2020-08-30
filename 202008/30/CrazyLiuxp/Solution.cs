public class Solution {
    public string ReverseWords(string s) {
        var arr = s.Split(' ');

        List<string> result = new List<string>();
        foreach(var str in arr)
        {
            result.Add(string.Join("", str.Reverse().ToArray()));
        }

        return string.Join(" ", result);
    }
}