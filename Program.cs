void FillArray(int[] array, int minimum, int maximum)
{
    Random random = new Random();
    int i=0;
    while(i<array.Length)
    {
        array[i] = random.Next(minimum,maximum);
        i++;
    }
}
int IndexOf(int[] array, int value)
{
    for(int i=0;i<array.Length;i++)
        if(array[i]==value)
            return i;
    return -1;
}
void PrintArray(int[] array)
{
    foreach(int element in array)
        Console.Write($"{element} ");
    Console.WriteLine();
}
void ChangeNegativeElements(int[] array)
{
    for(int i=0;i<array.Length;i++)
        if(array[i] < 0)
            array[i] = 0;
}
Console.Write("Enter length of array: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[length];
FillArray(array,-10,10);
PrintArray(array);
Console.Write("Eneter element to find in array: ");
int value = int.Parse(Console.ReadLine() ?? "0");
int index = IndexOf(array,value);
if(index==-1)
    Console.WriteLine("Array doen't contains this value");
else
    Console.WriteLine($"Index of element: {index}");
ChangeNegativeElements(array);
Console.Write("Your changed array: ");
PrintArray(array);