// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

// Метод выполняет сортировку строчек массива
int[,] Sort2DArray(int[,] matrix)
{
    int[] row = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            row[j] = matrix[i, j];
        }
        int[] sortRow = BubbleSort(row);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = sortRow[j];
        }
    }
    return matrix;
}

//Метод делает сортировку массива от наибольшего значения к наименьшему "пузырьком".

int[] BubbleSort(int[] arr)
{
    for (int j = 0; j < arr.Length - 1; j++)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[i + 1])
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
int[,] array2D = Fill2DArray(10, 10, 10, 99);
Console.WriteLine();
PrintData("Исходная таблица ");
Console.WriteLine();
Print2DArray(array2D);
Sort2DArray(array2D);
Console.WriteLine();
PrintData("Таблица отсортированна в порядке убываения построчно ");
Console.WriteLine();
Print2DArray(array2D);
Console.WriteLine();