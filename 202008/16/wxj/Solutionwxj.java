class Solutionwxj {
    int[] dx = {1,0,0,-1};
    int[] dy = {0,1,-1,0};
    public int[][] floodFill(int[][] image, int sr, int sc, int newColor) {
       int currColor = image[sr][sc];
       if(currColor != newColor){
            dfs(image,sr,sc,currColor,newColor);
        }
       return image;
    }

    void dfs(int[][] image, int sr, int sc,int currColor, int newColor){
        if(image[sr][sc] == currColor){
            image[sr][sc] = newColor;
            for(int i = 0; i < 4; i++){
                if( sr+dx[i] >= 0 && sr+dx[i] < image.length && sc+dy[i] >=0 && sc+dy[i] < image[0].length){
                    if(image[sr+dx[i]][sc + dy[i]] == currColor){
                        dfs(image,sr+dx[i],sc + dy[i],currColor,newColor);
                    }
                }
            }
        }
    }
}