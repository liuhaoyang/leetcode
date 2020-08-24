public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        int length = s.Length;
        for (int i = 1; i < length; i++)
        {
            bool match = true;
            if (length % i == 0)
            {
                for (int j = i; j < length; j++)
                {
                    if (s[j] != s[j - i])
                    {
                        match = false;
                        break;
                    }

                }

                if (match)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public bool RepeatedSubstringPattern2(string s)
    {
        return (s + s).IndexOf(s, 1) != s.Length;
    }
}