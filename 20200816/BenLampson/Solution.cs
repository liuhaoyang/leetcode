public class Solution
    {
        int oldData,newData, dimensional1, dimensional2 = 0;
        
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            if (image[sr][sc] != newColor)
            {
                oldData = image[sr][sc];
                newData = newColor;
                dimensional1 = image.Length;
                dimensional2 = image[0].Length;
                Fill(image, sr, sc );
            }

            return image;
        }

        public void Fill(int[][] image, int sr, int sc)
        {
            if (sr < 0 || sc < 0 || sr >= dimensional1 || sc >= dimensional2 || image[sr][sc] != oldData)
            {
                return;
            }
            image[sr][sc] = newData;
            Fill(image, sr+1, sc);
            Fill(image, sr-1, sc);
            Fill(image, sr, sc+1);
            Fill(image, sr, sc-1);
        }
    }
