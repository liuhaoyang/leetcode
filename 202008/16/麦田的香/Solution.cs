public class Solution {
   public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            int initColor = image[sr][sc];
            if (initColor == newColor)
            {
                return image;
            }
            dfs(image, sr, sc, initColor, newColor);
            return image;
        }

        public void dfs(int[][] image, int sr, int sc, int initColor, int newColor)
        {
            if (sr < 0 || sr > image.Count() - 1 || sc < 0
                    || sc > image[0].Count() - 1 || image[sr][sc] != initColor)
            {
                return;
            }
            image[sr][sc] = newColor;

            dfs(image, sr - 1, sc, initColor, newColor);//上
            dfs(image, sr + 1, sc, initColor, newColor);//下
            dfs(image, sr, sc - 1, initColor, newColor);//左
            dfs(image, sr, sc + 1, initColor, newColor);//右   
        }
    }
