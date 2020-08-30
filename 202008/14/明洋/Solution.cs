public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 == 1) 
            return false;

        var st = new System.Collections.Generic.Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            // 如果是左括号则 向栈添加
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                st.Push(s[i]);
            }
            // 如果栈内有值，并且 (栈顶值 与现在值相对应 无则返回false 有则去掉栈顶对应)
            else if (st.Count != 0 && ((st.Peek() == '(' && s[i] == ')') || (st.Peek() == '[' && s[i] == ']') || (st.Peek() == '{' && s[i] == '}')))
            {
                st.Pop();
                continue;
            }
            else
            {
                return false;
            }
        }
        return st.Count == 0;
    }
}