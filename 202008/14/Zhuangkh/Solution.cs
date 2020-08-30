public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 == 0)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> brackets = new Dictionary<char, char>()
            {
                {'(',')'},
                {'[',']'},
                {'{','}'}
            };

            foreach (var c in s)
            {
                if (brackets.ContainsKey(c))
                {
                    stack.Push(c);
                    continue;
                }

                if (stack.TryPop(out var temp) && brackets[temp] == c)
                {
                    continue;
                }

                return false;
            }

            return stack.Count == 0;
        }
        return false;
    }
}