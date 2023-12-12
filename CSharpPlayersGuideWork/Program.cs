static void Main(string[] args)
{
     
}


//Variable Shop - 14 types of common variables
/*int 
short
long 
byte 
sbyte
uint
ushort
ulong
char
string
float
double
decimal
bool
*/

/*
 * Console.WriteLine("P-Thag the triangle farmers area calculator");

Console.WriteLine("What is the base of the triangle?");
double triangleBase = Double.Parse(Console.ReadLine());

Console.WriteLine("What is the height of the triangle?");
double triangleHeight = Double.Parse(Console.ReadLine());

double area = (triangleBase * triangleHeight) / 2;

Console.WriteLine("The area of the triangle P-Thag is taking to market is " + area);
*/

//Four sisters and the duckbear

/*Console.WriteLine("Chandra's Egg divider");

Console.WriteLine("How many eggs did the chocolate chicken lay?");
int numberOfEggs = int.Parse(Console.ReadLine());
int sistersEggs = numberOfEggs / 4;

int duckbearEggs = numberOfEggs % 4;

Console.WriteLine($"There are {numberOfEggs}. Each of the sisters get {sistersEggs} and the duckbear gets {duckbearEggs} eggs.");
*/

/*
Console.WriteLine("How many provinces do you have?");
int provinces = int.Parse(Console.ReadLine());

Console.WriteLine("How many duchies do you have?");
int duchies = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many estates do you have?");
int estate = int.Parse(Console.ReadLine());

int provinceScore = provinces *= 6;
int duchiesScore = duchies *= 3;
int estateScore = estate *= 1;
int total = provinceScore + duchiesScore + estateScore;

Console.WriteLine($"You have {provinceScore} province points, {duchiesScore} duchy points, {estateScore} points, for a total of {total}");
*/

/*
Console.Title = "Defense of Consolas";
Console.Write("Target Row? ");
int targetRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column? ");
int targetColumn = Convert.ToInt32(Console.ReadLine());

// row 6 // column 5


Console.WriteLine("Deploy to: ");
Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"({targetRow} , {targetColumn - 1})");
Console.WriteLine($"({targetRow - 1} , {targetColumn})");
Console.WriteLine($"({targetRow} , {targetColumn + 1})");
Console.WriteLine($"({targetRow + 1} , {targetColumn})");
Console.Beep();
*/

/*
Console.Write("What number would you like to enter in to the clock? ");
int clockNum = Convert.ToInt32(Console.ReadLine());

if (clockNum % 2 == 0)
{
    Console.WriteLine("Tick");
} else
{
    Console.WriteLine("Tock");
}
*/

/*
Console.Write("Enter an x coordinate: ");
int xCoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a y coordinate: ");
int yCoord = Convert.ToInt32(Console.ReadLine());

if (xCoord < 0)
{
    if (yCoord > 0)
    {
        Console.WriteLine("The enemy is to the northwest!");
    } else if (yCoord == 0)
    {
        Console.WriteLine("The enemy is to the west!");
    } else
    {
        Console.WriteLine("The enemy is to the southwest!");
    }
}

if (xCoord == 0 )
{
    if (yCoord > 0)
    {
        Console.WriteLine("The enemy is to the north!");
    } else if (yCoord == 0)
    {
        Console.WriteLine("The enemy is here!");
    } else
    {
        Console.WriteLine("The enemey is to the south!");
    }
}

if (xCoord > 0)
{
    if (yCoord > 0)
    {
        Console.WriteLine("The enemy is to the northeast!");
    } else if (yCoord == 0)
    {
        Console.WriteLine("The enemy is to the east!");
    } else
    {
        Console.WriteLine("The enemy is to the southeast!");
    }
}
*/

