// Напишите программу, которая заполнит спирально массив 4 на 4.
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
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
            if (matrix[i, j] < 10)                                                                      //допечатываем к числу "0" если оно однозначное
            {
                Console.Write("0" + matrix[i, j] + "    ".Substring(matrix[i, j].ToString().Length));
                Console.ResetColor();
            }
            else
            {
                Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
                Console.ResetColor();
            }
        }
        Console.WriteLine();
    }
}

// Заполняем массив последовательно двигаясь по спирали
int[,] Snail2DArray(int countRow, int countColumn)
{
    int[,] array2D = new int[countRow, countColumn];
    int num = 1; int j = 0; int i = 0;
    for (int countCycle = 0; countCycle < (countRow); countCycle++) // колличество проходов зависит от размера массива
    {
        for (j = countCycle; j < (countColumn - countCycle); j++)     // заполняем строку слева направо
        {
            i = countCycle;
            array2D[i, j] = num++;
        }
        for (i = countCycle + 1; i < (countRow - countCycle); i++)   // заполняем столбец сверху вниз
        {
            j = countColumn - (countCycle + 1);
            array2D[i, j] = num++;
        }
        for (j = countColumn - (countCycle + 2); j >= countCycle; j--) // заполняем строку справа на лево
        {
            i = countRow - (countCycle + 1);
            array2D[i, j] = num++;
        }
        for (i = countRow - (countCycle + 2); i > countCycle; i--)     // заполняем столбец снизу вверх
        {
            j = countCycle;
            array2D[i, j] = num++;
        }
    }
    return array2D;
}

//___ПРОГРАММА___

Console.WriteLine();
int row = ReadData("Введите количество строк ");                                 // Пользователь вводит количество строк
int column = ReadData("Введите количество столбцов ");                           // Пользователь вводит количество столбцов
int[,] matrix = Snail2DArray(row, column);
Console.WriteLine();
Print2DArrayColor(matrix);
Console.WriteLine();


