// 1. print game title, instructions
Console.WriteLine("-----------------");
Console.WriteLine("| Repeater Game |");
Console.WriteLine("-----------------");

bool gameRunning = true;

while (gameRunning)
{
    // 2. render current game state
    Console.WriteLine("Do Next Repetition? (y = yes)");

    // 3. read input from console with Console.ReadLine()
    string input = Console.ReadLine();

    if (input != "y"/* 4. we need to abort */)
    {
        gameRunning = false;
        // game finished
    }
    else
    {
        // continue game
        Thread.Sleep(1500);  // 5. wait for 1.5s (if required)
        Console.Clear();     // 6. clear screen & re-render
    }
}
