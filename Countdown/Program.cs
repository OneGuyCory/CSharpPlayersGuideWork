//for (int x = 10; x > 0; x--)
//    Console.WriteLine(x);

void Countdown(int number)
{
    if (number == 0) return;
    Console.WriteLine(number);
    Countdown(number - 1);
}


Countdown(10);
