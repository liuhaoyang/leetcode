public class Solution
{
    public bool RepeatedSubstringPattern(string s)
    {
        // 如果输入abab  则abab + abab  截取到从1 取到最后一位前 (bababa) 看其是否包含abab有则true
        return (s + s).Substring(1, (s + s).Length - 2).Contains(s);
    }
}
