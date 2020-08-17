public class Solution
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
    {
        if (image[sr][sc] == newColor)
        {
            return image;
        }

        int oldColor = image[sr][sc];
        image[sr][sc] = newColor;

        if (sr != 0 && image[sr - 1][sc] == oldColor)
        {
            FloodFill(image, sr - 1, sc, newColor);
        }

        if (sr != image.Length - 1 && image[sr + 1][sc] == oldColor)
        {
            FloodFill(image, sr + 1, sc, newColor);
        }

        if (sc != 0 && image[sr][sc - 1] == oldColor)
        {
            FloodFill(image, sr, sc - 1, newColor);
        }

        if (sc != image[sr].Length - 1 && image[sr][sc + 1] == oldColor)
        {
            FloodFill(image, sr, sc + 1, newColor);
        }

        return image;
    }
}