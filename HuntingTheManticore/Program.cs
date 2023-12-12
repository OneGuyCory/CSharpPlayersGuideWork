int cityCurrentHealth = 15;
int manticoreCurrentHealth = 10;
int round = 1;
int manticorePlace;

manticorePlace = AskForNumberInRange("Player 1, how far away from the city do you want to station the Manticore? ", 0, 100);
Console.Clear();

Console.WriteLine("Player 2, it is your turn.");

// starts while loop for game, runs until city or manticore is defeated
while (cityCurrentHealth > 0 && manticoreCurrentHealth > 0)
{
    Console.WriteLine("-----------------------------------------------------------");
    CurrentStatus();

    // sets damage depending on round number
    // asks for cannon shot and sets cannonRange
    // gets shot status depending on cannon range and where manticore placed
    int damage = RoundDamage(round);
    Console.Write("Enter desired cannon range: ");
    int cannonRange = Convert.ToInt32(Console.ReadLine());
    ShotStatus(cannonRange, manticorePlace);

    // determines action to be done if it is a hit and does damage
    if (cannonRange == manticorePlace) manticoreCurrentHealth -= damage;
    // city takes 1 damage every round manticore is alive
    if (manticoreCurrentHealth > 0) cityCurrentHealth--;

    round++;

    // sets win as true when city health is above 0, gets status depending on that
    bool won = cityCurrentHealth > 0;
    DisplayWinner(won);
}


// gets number for manticore placement and makes sure its within range
int AskForNumberInRange(string text, int min, int max)
{

    do
    {
        Console.Write(text);
        manticorePlace = Convert.ToInt32(Console.ReadLine());
    }
    while (manticorePlace < min || manticorePlace > max);
    return manticorePlace;

}

// determines how much damage is done depening on round number
int RoundDamage(int round)
{
    if (round % 5 == 0 && round % 3 == 0) return 10;
    else if (round % 5 == 0) return 3;
    else if (round % 3 == 0) return 3;
    else return 1;
}


//displays current status of city and manticore and how much damage is expected
void CurrentStatus()
{
    Console.WriteLine($"\nSTATUS: Round: {round} City: {cityCurrentHealth}/15 Manticore: {manticoreCurrentHealth}/10");
    Console.WriteLine($"The cannon is expected to deal {RoundDamage(round)} damage this round.");
}


//displays status of cannon shot depending on its relation to manticore
void ShotStatus(int cannonRange, int manticorePlace)
{
    if (cannonRange > manticorePlace){Console.WriteLine("That round OVERSHOT the target.");}
    else if(cannonRange < manticorePlace) { Console.WriteLine("That round FELL SHORT of the target.");}
    else { Console.WriteLine("That was a DIRECT HIT!"); }
    
}

//displays winner depending on who hit 0 first
void DisplayWinner(bool won)
{
    if (won) { Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!"); }
    else { Console.WriteLine("The city has been destroyed! The Manticore is victorious."); }
}