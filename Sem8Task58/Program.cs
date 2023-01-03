// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод выводит на печать сообщение
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// Метод выводит на печать созданный массив
void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[matrix[i, j] % 15];
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Генерируем двумерный массив, заполненный случайными числами
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


// Метод умножения матриц
int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    //int[] temp = new int[matrix1.GetLength(1)];
    int sum = 0;
    int[,] outArr = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int k = 0; k < matrix2.GetLength(1); k++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                sum += matrix1[i, j] * matrix2[j, k];          // считаем произведение и складываем
            }
            outArr[i, k] = sum;                              //Записываем произведение в новую матрицу
            sum = 0;
        }
    }
    return outArr;
}

//___ПРОГРАММА___

Console.WriteLine();
int row = ReadData("Введите количество строк ");                                 // Пользователь вводит количество строк
int column = ReadData("Введите количество столбцов ");                           // Пользователь вводит количество столбцов
int[,] matrix1 = Fill2DArray(row, column, 0, 9);
int[,] matrix2 = Fill2DArray(row, column, 0, 9);
Console.WriteLine();
PrintData("Первая матрица");
Print2DArrayColor(matrix1);
PrintData("Вторая матрица");
Print2DArrayColor(matrix2);
int[,] productMatrix = ProductMatrix(matrix1, matrix2);
Console.WriteLine();
PrintData("Произведение матриц");
Console.WriteLine();
Print2DArrayColor(productMatrix);