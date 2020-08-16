using System;
using System.Collections.Generic;

namespace Problem20 {
    class Program {
        // 给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。
        // 有效字符串需满足：
        // 左括号必须用相同类型的右括号闭合。
        // 左括号必须以正确的顺序闭合。
        // 注意空字符串可被认为是有效字符串。

        // 示例 1:
        // 输入: "()"
        // 输出: true

        // 示例 2:
        // 输入: "()[]{}"
        // 输出: true

        // 示例 3:
        // 输入: "(]"
        // 输出: false

        // 示例 4:
        // 输入: "([)]"
        // 输出: false

        // 示例 5:
        // 输入: "{[]}"
        // 输出: true

        static void Main (string[] args) {
            Console.WriteLine (IsValid ("()"));
        }

        public static bool IsValid (string s) {

            if (s.Length % 2 == 1) {
                return false;
            }

            Stack<char> stack = new Stack<char> ();

            foreach (var item in s) {
                if (stack.Count == 0) {
                    stack.Push (item);
                    continue;
                }

                var topItem = stack.Peek ();

                switch (topItem) {
                    case '(':
                        if (item == ')') {
                            stack.Pop ();
                        } else {
                            stack.Push (item);
                        }
                        break;
                    case '[':
                        if (item == ']') {
                            stack.Pop ();
                        } else {
                            stack.Push (item);
                        }
                        break;
                    case '{':
                        if (item == '}') {
                            stack.Pop ();
                        } else {
                            stack.Push (item);
                        }
                        break;
                    case ')':
                        return false;
                    case ']':
                        return false;
                    case '}':
                        return false;
                }

            }

            return stack.Count == 0;
        }

    }
}