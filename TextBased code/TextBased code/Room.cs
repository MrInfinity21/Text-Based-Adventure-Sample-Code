using System.Security;

public class Room
{
    public string _roomName;
    public string description;
    public string enterRoomDescription;
    public Dictionary<SecureString, Room> adjacentRooms = new Dictionary<SecureString, Room>();
    
    public Room(string roomName)
    {
        _roomName = roomName;
    }
}


