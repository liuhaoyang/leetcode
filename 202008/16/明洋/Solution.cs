public class Solution
{
    public int[][] floodFill(int[][] image, int sr, int sc, int newColor)
    {
        int oldColor = image[sr][sc];
        if (oldColor != newColor)
            ChangeColor(image, sr, sc, newColor, oldColor);
        return image;
    }

    private void ChangeColor(int[][] image, int x, int y, int newColor, int oldColor)
    {
        // 判断是否超出边界
        if (x < 0 || x >= image.Length || y < 0 || y >= image[0].Length) return;

        if (image[x][y] == oldColor)
        {
            image[x][y] = newColor;

            // 递归寻找四周是否有无，有则替换并继续递归,递归终止条件为超出边界和不是oldColor
            ChangeColor(image, x - 1, y, newColor, oldColor);
            ChangeColor(image, x + 1, y, newColor, oldColor);
            ChangeColor(image, x, y - 1, newColor, oldColor);
            ChangeColor(image, x, y + 1, newColor, oldColor);
        }

        return;
    }
}