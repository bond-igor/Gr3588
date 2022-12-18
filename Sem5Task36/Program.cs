// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// Метод создает массив заданого размера, заполненный случайными числами.
int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}

//Метод выводит созданный массив.
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// Метод выводит результат.
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

//Метод считает сумму нечетных чисел в массиве
int SumOdd(int[] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i +=2)
    {
       res += arr[i];
    }
    return res;
}

//___ПРОГРАММА___

int[] array = GenArray(6, 100, 1000);
Print1DArr(array);
Console.WriteLine();
int result = SumOdd(array);
PrintData("Сумма нечетных чисел: ", result);
