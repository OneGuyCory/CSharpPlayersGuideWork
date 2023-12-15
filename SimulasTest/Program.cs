ChestState currentState = ChestState.Locked;
string playerChoice;



do
{
    Console.Write($"The chest is {currentState}. What do you want to do? ");
    playerChoice = Console.ReadLine().ToLower();

    if (playerChoice == "unlock")
    {
        currentState = ChestState.Unlocked;
    }
    else if (playerChoice == "open")
    {
        currentState = ChestState.Open;
    }
    else if (playerChoice == "close")
    {
        currentState = ChestState.Unlocked;
    }
    else if (playerChoice == "lock")
    {
        currentState = ChestState.Locked;
    }
    else
    {
        Console.WriteLine("Please select open, lock, unlock, close.");
    }
} while (playerChoice != "EXIT");



enum ChestState
{
    Locked,
    Unlocked,
    Open,
    Closed
}