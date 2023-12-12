/*
Build a program that will allow a user, the pilot, to enter a number.

If the number is above 100 or less than 0, keep asking.

Clear the screen once the program has collected a good number.

Ask a second user, the hunter, to guess numbers.

Indicate whether the user guessed too high, too low, or guessed right.

Loop until they get it right, then end the program */

int pilotNumber = AskForNumberInRange("User 1, Enter a number between 0 and 100: ", 1, 100);
int hunterNumber;

//do
//{
//    Console.Write("User 1, Enter a number between 0 and 100: ");
//    pilotNumber = Convert.ToInt32(Console.ReadLine());
//}
//while (pilotNumber < 0 || pilotNumber > 100);
Console.Clear();

Console.WriteLine("User 2, guess the number");

do
{
    Console.Write("What is your next guess? ");
    hunterNumber = Convert.ToInt32(Console.ReadLine());

    if (hunterNumber > pilotNumber)
    {
        Console.WriteLine(hunterNumber + " is too high.");
    } else if (hunterNumber < pilotNumber)
    {
        Console.WriteLine(hunterNumber + " is too low.");
    } else
    {
        Console.WriteLine("You guessed the number!");
    }

}
while (hunterNumber != pilotNumber);

int AskForNumberInRange(string text, int min, int max)
{
    
    do
    {
        Console.Write(text);
        pilotNumber = Convert.ToInt32(Console.ReadLine());
    }
    while (pilotNumber < min || pilotNumber > max);
    return pilotNumber;
}
