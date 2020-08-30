using System;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Solution.IsValid("()"));
            Console.WriteLine(Solution.IsValid("(("));
            Console.WriteLine(Solution.IsValid("(([]){})"));
            Console.ReadLine();
        }



        public static class Solution
        {
            public static bool IsValid(string s)
            {
                if (s.Length % 2 == 1)
                {
                    return false;
                }
                var stacks = new System.Collections.Generic.Stack<char>();
                var hash = new System.Collections.Hashtable();
                hash.Add(')', '(');
                hash.Add(']', '[');
                hash.Add('}', '{');
                var chars = s.ToCharArray();
                foreach (var c in chars)
                {
                    if (hash.ContainsKey(c))
                    {
                        if (stacks.Count==0 || (char)hash[c] != stacks.Peek())
                        {
                            return false;
                        }
                        stacks.Pop();
                    }
                    else
                    {
                        stacks.Push(c);
                    }
                }
                if(stacks.Count != 0)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
