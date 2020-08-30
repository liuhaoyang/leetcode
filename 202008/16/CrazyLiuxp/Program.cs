class Program{
	
	int[] vx = new int[] { -1, 0, 1, 0 };
	int[] vy = new int[] { 0, 1, 0, -1 };

	public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
	{
		var originColor = image[sr][sc];
		Fill(image, sr, sc, originColor, newColor);
		return image;
	}

	private void Fill(int[][] image,int sr,int sc,int originColor,int newColor)
	{
		if (sr < 0 || sr >= image.Length || sc < 0 || sc >= image[0].Length) return;
		if (image[sr][sc] != originColor || image[sr][sc]==newColor) return;

		image[sr][sc] = newColor;

		for(int i = 0; i < 4; i++)
		{
			var x = sr + vx[i];
			var y = sc + vy[i];
			Fill(image, x, y, originColor, newColor);
		}
	}
}