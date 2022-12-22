// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

// Метод выводит на печать сообщение
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Метод выводит на печать созданный массив
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Метод находит среднее арифметическое в каждом столбце массива
int[] AverageColumn(int[,] array2D)
{
    int[] avr = new int[array2D.GetLength(1)];
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        for (int i = 0; i < array2D.GetLength(0); i++)
        {
            avr[j] += array2D[i, j];
        }
        avr[j] = avr[j] / array2D.GetLength(0);
    }

    return avr;
}

//Метод, выводящий на печать массив
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

//___ПРОГРАММА___
int[,] array2D = Fill2DArray(5, 5, 10, 99);
Print2DArray(array2D);
int[] avr = AverageColumn(array2D);
PrintData("Среднее: ");
Print1DArr(avr);
