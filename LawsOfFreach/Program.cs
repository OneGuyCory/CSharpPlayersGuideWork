/*int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.
for (int index = 0; index < array.Length; index++)
{
    if (array[index] < currentSmallest)
        currentSmallest = array[index];
}
Console.WriteLine(currentSmallest);*/

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue;

foreach (int i in array)
{
    if (i < currentSmallest)
    {
        currentSmallest = i;
    }
}
Console.WriteLine(currentSmallest);

/*int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
for (int index = 0; index < array.Length; index++)
    total += array[index];
float average = (float)total / array.Length;
Console.WriteLine(average)*/

int[] otherArray = new int[] { 4, 51, -7, 13, -99, -8, 45, 90 };
int total = 0;
foreach (int i in otherArray)
{
    total += i;
    float average = (float)total / otherArray.Length;
    Console.WriteLine(average);
}
