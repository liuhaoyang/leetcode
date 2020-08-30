public class Solution {
    public bool IsValid(string s) {
               Stack<char> charList = new Stack<char>();            
            foreach (var item in s)
            {
                if (charList.Count==0)
                {
                    charList.Push(item);
                }
                else
                {
                    switch (charList.Peek())
                    {
                        case '[':
                            if (item==']')
                            {
                                charList.Pop();
                            }
                            else
                            {
                                charList.Push(item);
                            }
                            break;
                        case '{':
                            if (item == '}')
                            {
                                charList.Pop();
                            }
                            else
                            {
                                charList.Push(item);
                            }
                            break;
                        case '(':
                            if (item == ')')
                            {
                                charList.Pop();
                            }
                            else
                            {
                                charList.Push(item);
                            }
                            break; 
                    }
                }
                
            }
            return charList.Count == 0;
    }
}
