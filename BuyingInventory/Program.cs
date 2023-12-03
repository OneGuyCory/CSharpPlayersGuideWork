Console.WriteLine($@"The following items are available:
1 - Rope
2 - Torches
3 - Climbing Equipment
4 - Clean Water
5 - Machete 
6 - Canoe
7 - Food Supplies");
Console.Write("What is your name? ");
string name = Console.ReadLine();

Console.Write("What number do you want to see the price of? ");
int choice = Convert.ToInt32(Console.ReadLine());

if (name == "Cory")
{
    string response;

    response = choice switch
    {
        1 => "5",
        2 => "7.5",
        3 => "12.5",
        4 => ".50",
        5 => "10",
        6 => "100",
        7 => ".50",
        _ => "Choice not recognized."
    };
    Console.WriteLine(response);
} else
{
    string response;

    response = choice switch
    {
        1 => "10",
        2 => "15",
        3 => "25",
        4 => "1",
        5 => "20",
        6 => "200",
        7 => "1",
        _ => "Choice not recognized."
    };
    Console.WriteLine(response);
}

