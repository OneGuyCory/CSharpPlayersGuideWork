﻿int result = AskForNumber("What is the airspeed velocity of an unladen swallow? ");
Console.WriteLine(result);

int newResult = AskForNumberInRange("Pick a number between 1 and 10 ", 1, 10);

Console.WriteLine(newResult);
int AskForNumber(string text)
{
    Console.Write(text);
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int AskForNumberInRange(string text, int min, int max)
{
    int num;

    do
    {
        Console.Write(text);
         num = Convert.ToInt32(Console.ReadLine());
    }
    while (num < min || num > max);
    return num;
}
    
//added AskForNumberInRange method to Prototype project