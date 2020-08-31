public class Solution
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        int rc = rooms.Count;
        List<int> keys = new List<int>() { 0 };
        CanVisitAllRooms(rooms, keys, 0);
        return keys.Count() == rooms.Count;
    }

    public static void CanVisitAllRooms(IList<IList<int>> rooms, List<int> keys, int room)
    {
        int rc = rooms.Count;
        foreach (var i in rooms[room])
        {
            if (!keys.Contains(i))
            {
                keys.Add(i);
                if (keys.Count() == rc)
                {
                    return;
                }

                CanVisitAllRooms(rooms, keys, i);
            }
        }
    }
}