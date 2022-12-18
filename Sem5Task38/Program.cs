// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Метод создает массив заданого размера, заполненный случайными числами.
double[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
        arr[i] = arr[i] / 100;
    }
    return arr;
}

//Метод выводит созданный массив.
void Print1DArr(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// Метод выводит результат.
void PrintData(string res, double value)
{
    Console.WriteLine(res + value);
}

double min = double.MaxValue;
double max = double.MinValue;
//Метод внаходит разницу между максимальным и минимальным элементами массива
void MinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
}

//___ПРОГРАММА___

double[] array = GenArray(12, 100, 1000);
Print1DArr(array);
Console.WriteLine();
MinMax(array);
PrintData("Максимальное значение: ", max);
PrintData("Минимальное значение: ", min);
double result = max - min;
PrintData("Разница между максимальным и минимальным значениями = ", result);