public class Solution
{
    public string ReverseWords(string s)
    {
        var arr = s.Split(" ");
        var result = string.Empty;
        for (var index = 0; index < arr.Length; index++)
        {
            foreach (var item in arr[index].Reverse())
            {
                result += item;
            }
            if (index != arr.Length - 1) result += " ";
        }

        return result;
    }
}