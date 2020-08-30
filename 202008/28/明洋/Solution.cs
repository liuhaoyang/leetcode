public class Solution {
    public bool JudgeCircle(string moves) {
        if(moves == null || moves  == "") return false;

        int x = 0; 
        int y = 0;
        for(int i = 0; i< moves.Length; i++)
        {
            if(moves[i] == 'R') x += 1;
            if(moves[i] == 'L') x -= 1;
            if(moves[i] == 'U') y += 1;
            if(moves[i] == 'D') y -= 1;
        }

        return x == 0 && y == 0;
    }
}