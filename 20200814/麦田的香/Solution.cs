        public bool IsValid_2(string s)
        {
            Dictionary<char, char> dic = new Dictionary<char, char>
            {
                { ']', '[' },
                { ')', '(' },
                { '}', '{' }
            };
            var stack = new Stack<char>();
            foreach (var item in s)
            {
                if (dic.ContainsKey(item))
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        var element = stack.Pop();
                        if (element != dic[item])
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
            //ex:"[[["
            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }