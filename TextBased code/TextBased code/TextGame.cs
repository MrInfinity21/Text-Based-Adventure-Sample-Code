public class TextGame
{
    private Room _currentRoom;
    private bool _isGameRunning = true;

    public void InitializeGame()
    {
        Room mainHallway = new Room("Main Hallway");
        mainHallway.description = "You are in a large hallway with" + "the front door closed behind you.";
        mainHallway.enterRoomDescription = "you enter an elegant grand hallway.";

        _currentRoom = mainHallway;
        
        Room kitchen = new Room("Kitchen");
        kitchen.description = "You enter a kitchen, the smell" + "the front door closed behind you.";
        kitchen.enterRoomDescription = "you enter an elegant grand hallway.";
        
        mainHallway.adjacentRooms.Add("east", kitchen);
        kitchen.adjacentRooms.Add("west", kitchen);

        Console.WriteLine("You are in a large hallway.");
    }

    public void ProcessUserInput(string command, string subject)
    {
        if (command == "go")
        {
            if (subject == "north")
            {
                if (_currentRoom.adjacentRooms.ContainsKey(subject))
                {
                    _currentRoom = _currentRoom.adjacentRooms[subject];
                }   
            }
            
        }   
    }

    public void ProcessTwoWords(string command, string Subject)
    {
        
    }
    

    public bool GameIsRunning()
    {
        return _isGameRunning;
    }
}