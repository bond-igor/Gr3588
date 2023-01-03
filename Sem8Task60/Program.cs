// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод выводит на печать созданный массив с индексами элементов
void Print3DArrayColor(int[,,] matrix)
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
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.ForegroundColor = col[matrix[i, j, k] % 15];
                Console.Write(($"{matrix[i, j, k]} ({i}, {j}, {k})") + "     ".Substring(matrix[i, j, k].ToString().Length));
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}

// Метод создает список двухзначных чисел
List<int> num = new List<int>();
for (int i = 0; i < 90; i++)
{
    num.Add(10 + i);
}

//Метод генерации случайных неповторяющихся двузначных чисел
int GenNum(List<int> num)
{
    int index = new Random().Next(0, 82);
    int outNum = num[index];
    num.RemoveAt(index);
    return outNum;
}

// Генерируем трехмерный массив, заполненный случайными числами
int[,,] Fill3DArray(int countRow, int countColumn, int countList)
{
    int[,,] array3D = new int[countRow, countColumn, countList];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            for (int k = 0; k < countList; k++)
            {
                array3D[i, j, k] = GenNum(num);
            }
        }
    }
    return array3D;
}

//___ПРОГРАММА___

Console.WriteLine();
int x = ReadData("Введите X ");
int y = ReadData("Введите Y ");
int z = ReadData("Введите Z ");
int[,,] matrix3D = Fill3DArray(x, y, z);
Console.WriteLine(num.Count);
Console.WriteLine();
Print3DArrayColor(matrix3D);
Console.WriteLine();
