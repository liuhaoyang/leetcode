public class Solution {
    public bool PredictTheWinner(int[] nums) {
        if (nums == null || nums.Length < 1)
        {
            return false;
        }

        int n = nums.Length;
        int[,] first = new int[n, n];
        int[,] last = new int[n, n];
        for (int r = 0; r < n; r++)
        {
            first[r, r] = nums[r];
            for (int l = r - 1; l >= 0; l--)
            {
                first[l, r] = Math.Max(nums[l] + last[l + 1, r], nums[r] + last[l, r - 1]);
                last[l, r] = Math.Min(first[l + 1, r], first[l, r - 1]);
            }
        }

        return first[0, n - 1] >= last[0, n - 1];
    }
}