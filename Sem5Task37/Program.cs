int[] array = GenArray(123,-100,100);
PrintArray(array);
Console.WriteLine();
int[] result = ConvertArr(array);
PrintArray(result);
Console.WriteLine();

int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}

void PrintArray(int[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

int[] ConvertArr(int[] array)
{
    int[] outArr = new int[array.Length/2];
    for (int i = 0; i < array.Length/2; i++)
    {
        outArr[i]=array[i]*array[array.Length-1 -i];
    }
    return outArr;
}