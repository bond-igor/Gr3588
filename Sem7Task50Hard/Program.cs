// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру


//___ПРОГРАММА___
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArrayFibNum(row, column);
//Print2DArray(arr2D);
int rowI = ReadData("Введите индекс строки: ");
int columnJ = ReadData("Введите индекс столбца: ");
int elem = SearchElem(arr2D, rowI, columnJ);
Print2DArray(arr2D);

//Метод, считывающий данные, введенные пользователем
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива числами Фибоначи
int[,] Fill2DArrayFibNum(int countRow, int countColumn)
{
    int first = 0;
    int last = 1;
    int buf = 0;
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = (first + last);
            buf = last;
            last = first + last;
            first = buf;
        }
    }
    return array2D;
}

// Метод возвращает значения элемента массива на указанной позиции
int SearchElem(int[,] matrix, int i, int j)
{
    int elem = -1;
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
    {
        elem = matrix[i, j];
    }

    return elem;
}

// Метод выводит на печать массив
void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == elem)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
                Console.ResetColor();
            }
            else
            {
                Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
            }
        }
        Console.WriteLine();
    }
}


