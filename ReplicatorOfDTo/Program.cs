int[] array = new int[5];
int[] copiedArray = new int[5];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Enter a number: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0;i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

for (int i = 0; i < array.Length; i++)
{
    copiedArray[i] = array[i];
}

for (int i = 0; i < copiedArray.Length; i++)
{
    Console.WriteLine(copiedArray[i]);
}