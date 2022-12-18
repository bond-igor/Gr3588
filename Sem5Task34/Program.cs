// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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

// Метод делает проверку на четность элементов массива
bool EvenTest(int evenNum)
{
    return (evenNum % 2 == 0);
}

//Метод считает колличество четных чисел в массиве
int CountEven(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (EvenTest(arr[i]))
        {
            res++;
        }
    }
    return res;
}

//Метод делает сортировку массива от наименьшего значения к наибольшему "пузырьком".

int[] ArraySort(int[] arr)
{
    for (int j = 0; j < arr.Length - 1; j++)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
               int Temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = Temp;
            }
        }
    }
    return arr;
}


//___ПРОГРАММА___

int[] array = GenArray(123, 100, 1000);
Print1DArr(array);
Console.WriteLine();
int result = CountEven(array);
PrintData("Четных чисел: ", result);
Console.WriteLine();
int[] sortArray = ArraySort(array);
Print1DArr(sortArray);