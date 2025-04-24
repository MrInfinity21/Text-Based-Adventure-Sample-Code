Console.WriteLine("Welcome to 2D Adventure");

TextGame currentGame = new TextGame();
currentGame.InitializeGame();

while (currentGame.GameIsRunning())
    
{
    Console.WriteLine("What would you like to do?");
    string usersInput = Console.ReadLine();
    
    Console.Clear();
    
    string[] userInputArray = usersInput.Split(' ');
    for (int i = 0; i < userInputArray.Length; i++)
    {
        Console.WriteLine(userInputArray[i]);
    }
    
}






