public class Solution {
    public bool JudgeCircle (string moves) {
        int u = 0, v = 0;
        foreach (char c in moves) {
            switch (c) {
                case 'R':
                    u++;
                    break;
                case 'L':
                    u--;
                    break;
                case 'U':
                    v++;
                    break;
                case 'D':
                    v--;
                    break;
            }
        }
        return u == 0 && v == 0;
    }
}