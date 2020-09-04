public class Solution
{
    public bool PredictTheWinner(int[] nums)
    {
        return PredictTheWinner(nums, 0, 0, 0, nums.Length - 1, 0);
    }
    public bool PredictTheWinner(int[] nums, int gradeA, int gradeB, int startIndex, int lastIndex, int curIndex)
    {

        if (curIndex < nums.Length)
        {
            bool left, right;
            if (curIndex % 2 == 0)
            {
                left = PredictTheWinner(nums, gradeA + nums[startIndex], gradeB, startIndex + 1, lastIndex, curIndex + 1);
                right = PredictTheWinner(nums, gradeA + nums[lastIndex], gradeB, startIndex, lastIndex - 1, curIndex + 1);
                //先手只要任一赢
                return left || right;
            }
            else
            {
                left = PredictTheWinner(nums, gradeA, gradeB + nums[startIndex], startIndex + 1, lastIndex, curIndex + 1);
                right = PredictTheWinner(nums, gradeA, gradeB + nums[lastIndex], startIndex, lastIndex - 1, curIndex + 1);
                //后手选择对于先手来说要无论如何赢才可
                return left && right;
            }
        }

        return gradeA >= gradeB;

    }
}

public class Solution
{
    public bool PredictTheWinner(int[] nums)
    {
        return PredictTheWinner(nums, 0, 0, nums.Length - 1, 1) >= 0;
    }
    public int PredictTheWinner(int[] nums, int total, int startIndex, int lastIndex, int a)
    {
        if (startIndex == lastIndex)
        {
            return nums[startIndex] * a;
        }
        int left = nums[startIndex] * a + PredictTheWinner(nums, total + nums[startIndex], startIndex + 1, lastIndex, -a);
        int right = nums[lastIndex] * a + PredictTheWinner(nums, total + nums[lastIndex], startIndex, lastIndex - 1, -a);

        return Math.Max(left * a, right * a) * a;
    }
}