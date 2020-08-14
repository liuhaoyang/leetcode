using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeDailyTraining._20200814.Turbo
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            if (s.Length % 2 != 0)
            {
                return false;
            }
            Dictionary<char, char> map = new Dictionary<char, char>()
            {
                {')','(' },
                {']','[' },
                {'}','{' }
            };
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                var item = s[i];
                if (map.Values.Contains(item))
                {
                    stack.Push(item);
                }
                else
                {
                    if(stack.Count == 0 || map[item] != stack.Pop())
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

        /// <summary>
        /// Marked from CrazyLiuxp
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid2(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            if (s.Length % 2 != 0)
            {
                return false;
            }

            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (stack.Count == 0)
                {
                    stack.Push(c);
                }
                else if (c - stack.Peek() == 1 || c - stack.Peek() == 2)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            return !stack.Any();
        }
    }
}
