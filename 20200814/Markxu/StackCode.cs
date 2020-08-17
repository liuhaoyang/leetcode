using System;
using System.Collections.Generic;
using System.Text;

namespace MyLeetCode
{
    public class StackCode
    {
        public bool IsValid_2(string s)
        {
            if (s.Length % 2 == 1)
            {
                return false;
            }
            Dictionary<char, char> map = new Dictionary<char, char>
            {
                { ']', '[' },
                { ')', '(' },
                { '}', '{' }
            };
            var stack = new Stack<char>();

            foreach (var item in s)
            {
                if (map.ContainsKey(item))
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        var element = stack.Pop();
                        if (element != map[item])
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    stack.Push(item);
                }
            }
            return stack.Count == 0;
        }


    }
}
