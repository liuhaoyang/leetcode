public class Solution {
    private int jiechen(int n)
    {
        if (n <= 1) return n;
        return n * jiechen(n - 1);
    }
    public string GetPermutation(int n, int k)
    {
        List<int> leftlist = new List<int>();
        for (int i = 1; i <= n; i++)
            leftlist.Add(i);
        //leftlist剩余需要找的个数
        string forreturn = "";
        while (leftlist.Count > 1)
        {
            int jiechenval = jiechen(n - 1);
            double shang = k * 1.0 / jiechenval;
            if (shang % 1 != 0)
                shang = 1 + Math.Truncate(shang);
            int removeindex = (int)shang - 1;
            forreturn += leftlist[removeindex];
            leftlist.RemoveAt(removeindex);
            k = k - removeindex * jiechenval;
            n--;
        }
        forreturn += leftlist[0].ToString();
        return forreturn;
    }
}