public class Solution {
    // 1.当前点击的是【未挖出来的雷】，我们将其改为X即可,表示点到了雷，然后结束。
    // 2.当前点击的是【为挖出的空方块】，我们需要统计他周围相邻（八个）的方块里的地雷的数量cnt（即M的数量）。
    //   如果cnt>0，就将当前方块改为cnt的数字(附近的雷数)
    //   如果cnt为0，则将其改为B，并递归计算周围八个未挖出的方块，如果没有更多方块可以被揭露，则返回面板。
    public char[][] UpdateBoard (char[][] board, int[] click) {
        int x = click[0], y = click[1];

        //如果当前坐标位置处为M，则点中了“雷”，则Game over
        if (board[x][y] == 'M') {
            board[x][y] = 'X';
        } else {
            dfs (board, x, y);
        }

        return board;
    }

    //左、左上、上、右上、右、右下、下、左下
    int[] vx = new int[] {-1, -1, 0, 1, 1, 1, 0, -1 };
    int[] vy = new int[] { 0, -1, -1, -1, 0, 1, 1, 1 };
    private void dfs (char[][] board, int x, int y) {
        //计算当前点[x,y]周围M的数量
        int cnt = 0;
        for (int i = 0; i < 8; i++) {
            int currentX = x + vx[i];
            int currentY = y + vy[i];

            //跳过不符合递归条件的块
            //1.如果坐标超出范围
            if (currentX < 0 || currentX >= board.Length || currentY < 0 || currentY >= board[0].Length) {
                continue;
            }

            if (board[currentX][currentY] == 'M') {
                cnt++;
            }
        }

        //周围M个数不为0时，将[x,y]处的值设置成cnt数字
        if (cnt > 0) {
            board[x][y] = (char) (cnt + '0');
        } else {
            //将[x,y]初的值设置成B
            board[x][y] = 'B';

            //递归周围8个点
            for (int i = 0; i < 8; i++) {
                int currentX = x + vx[i];
                int currentY = y + vy[i];

                //跳过不符合递归条件的块
                //1.如果坐标超出范围
                //2.或者当前坐标处值为B，表示当前坐标已经处理过
                if (currentX < 0 || currentX >= board.Length || currentY < 0 || currentY >= board[0].Length || board[currentX][currentY] != 'E') {
                    continue;
                }

                dfs (board, x + vx[i], y + vy[i]);
            }
        }
    }
}