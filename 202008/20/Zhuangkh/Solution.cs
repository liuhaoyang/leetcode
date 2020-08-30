public class Solution
{
    public char[][] UpdateBoard(char[][] board, int[] click)
    {
       //检查数组合规性,或者点击的是否为Blank
       if (click.Length != 2 || click[0] > board.Length || click[1] > board[click[0]].Length || board[click[0]][click[1]] == 'B')
       {
           return board;
       }

       int r = click[0], c = click[1];

       //检查是否为Mine
       if (board[r][c] == 'M')
       {
           board[r][c] = 'X';
           return board;
       }

       //检查周围八方块是否有Mine,有则最终修改当前方块数量,无则递归周围八方块
       int[] u = { -1, -1, -1, 0, 0, 1, 1, 1 };
       int[] v = { -1, 0, 1, -1, 1, -1, 0, 1 };
       int mines = 0;
       for (int i = 0; i < 8; i++)
       {
           if (r + u[i] < 0 || c + v[i] < 0 || r + u[i] >= board.Length || c + v[i] >= board[r].Length)
           {
               continue;
           }

           if (board[r + u[i]][c + v[i]] == 'M')
           {
               mines++;
           }
       }

       if (mines > 0)
       {
           board[r][c] = (char)('0' + mines);
           return board;
       }

       board[r][c] = 'B';

       for (int i = 0; i < 8; i++)
       {
           if (r + u[i] < 0 || c + v[i] < 0 || r + u[i] >= board.Length || c + v[i] >= board[r].Length)
           {
               continue;
           }

           board = UpdateBoard(board, new int[] { r + u[i], c + v[i] });
       }

       return board;
}