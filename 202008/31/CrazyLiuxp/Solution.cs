public class Solution {
    private bool[] vis;
    private int num;
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        int len = rooms.Count;
        vis = new bool[len];
        num = 0;

        //从第0个房间开始
        dfs(rooms, 0);

        return num == len;
    }

    private void dfs(IList<IList<int>> rooms, int index)
    {
        vis[index] = true;
        num++;
        
        foreach(var roomNum in rooms[index]){
            if (!vis[roomNum])
            {
                dfs(rooms, roomNum);
            }
        }
    }
}