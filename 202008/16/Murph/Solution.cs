public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
            var hub = image[sr][sc]; // 中心点的基准值
            var maxX = image.Length;
            if (hub == newColor) return image;

            void next(int x, int y)
            {
                Console.WriteLine($"{x} {y}");
                if (x < 0 || x >= maxX) return;
                if (y < 0 || y >= (image[x]?.Length ?? 0)) return;
                if (image[x][y] != hub) return;
                image[x][y] = newColor;
                
                next(x + 1, y);
                next(x - 1, y);
                next(x, y + 1);
                next(x, y - 1);
            }

            next(sr, sc);
            return image;
    }
}