public class Solution {
    public bool IsValid(string s)
        {
            if (s == "") return true;
            if (s.Length%2 != 0) return false;
            Stack stack = new Stack();
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i]=='('|| s[i] == '['|| s[i] == '{')
                {
                    //遇到左括号进栈
                    stack.Push(s[i]);
                }
                //栈空时遇到右括号 直接false
                if ((s[i] == ')' || s[i] == ']' || s[i] == '}') && stack.Count == 0)
                    return false;
                //遇到右括号且与栈顶匹配
                if (s[i] == ']')
                {
                    if ((char)stack.Peek() != '[')
                        return false;
                    else
                        stack.Pop();

                }
                if (s[i] == ')')
                {
                    if ((char)stack.Peek() != '(')
                        return false;
                    else
                        stack.Pop();

                }
                if (s[i] == '}')
                {
                    if ((char)stack.Peek() != '{')
                        return false;
                    else
                        stack.Pop();

                }
            }
            //结束时栈空
            if (stack.Count == 0)
                return true;
            else
                return false;
        }
}