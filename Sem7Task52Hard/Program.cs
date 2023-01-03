//=======================================================
// # 52 Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.
// * Дополнительно вывести среднее арифметическое
// по диагоналям и диагональ выделить разным цветом.
//=======================================================

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод генерации и заполнения массива
int[,] Fill2DArray(int rows, int cols, int numMin, int numMax)
{
    // Создаём массив
    int[,] array2D = new int[rows, cols];

    if (numMin < numMax)
    {
        // Заполняем массив
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array2D[i, j] = new Random().Next(numMin, numMax + 1);
            }
        }
    }

    return array2D;
}

// Метод, печатает одномерный массив разными цветами
void Print1DArrayColored(double[] arr, ConsoleColor[] colors)
{
    string arrString = String.Empty;

    // В цикле меняем цвет шрифта, печатаем, сбрасываем цвет
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = colors[i % colors.Length];
        Console.Write($"{arr[i]} ");
        Console.ResetColor();
    }
}

// Метод, печатает двумерный массив с диагоналями разных цветов
void Print2DArrayColored(int[,] arr, ConsoleColor[] colors)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // Вычисляем индекс цвета - номер диагонали в двумерном массиве
            Console.ForegroundColor = colors[(j - i + (arr.GetLength(0) - 1)) % colors.Length];
            Console.Write($"{arr[i, j]} ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// Метод, принимает двумерный массив, возвращает одномерный массив средних арифметических по диагоналям
double[] CalcAvrgDiagonals(int[,] arr)
{
    // Создаём одномерный массив с длиной - количеством диагоналей
    double[] diagAverages = new double[arr.GetLength(1) + arr.GetLength(0) - 1];

    // В циклах проходим по двумерному массиву, суммируя элементы по диагоналям
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // Вычисляем индекс - номер диагонали, накапливаем сумму
            diagAverages[j - i + (arr.GetLength(0) - 1)] += arr[i, j];
        }
    }
    // Возвращаем массив, разделяя каждый элемент на количество элементов в диагонали
    return DivideArrDiagonals(diagAverages, arr.GetLength(0));
}

// Метод, принимает массив и макс. кол-во элементов в диагонали, делит каждый элемент на нужное количество
double[] DivideArrDiagonals(double[] arr, int maxDivider)
{
    for (int i = 0; i < arr.Length; i++)
    {
        // Вычисляем количество элементов в определённой диагонали, делим элемент массива на это количество
        int diagSize = Math.Min(Math.Min(i + 1, maxDivider), arr.Length - i);
        arr[i] = Math.Round(arr[i] / diagSize, 2);
    }

    return arr;
}

// Данные для генерации массива
int numMin = 10;
int numMax = 99;
// Получаем массив консольных цветов
ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

int inputRows = ReadData("Введите количество строк: ");
int inputCols = ReadData("Введите количество столбцов: ");
int[,] array2D = Fill2DArray(inputRows, inputCols, numMin, numMax);
PrintResult($"Случайный массив целых чисел {inputRows}x{inputCols}:");
Print2DArrayColored(array2D, colors);
PrintResult("Средние арифметические по диагоналям:");
Print1DArrayColored(CalcAvrgDiagonals(array2D), colors);

// //==========================================
// //#52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// //столбце. * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом
// //==========================================

// // Запрос данных пользователяю, принимает строку заголовок.
// // Выдает введеное число, в случае ошибки выдает 0.
// int ReadData(string greeting = "Введите данные")
// {
//     Console.WriteLine(greeting);
//     int.TryParse((Console.ReadLine() ?? "0"), out int number); // переводим в число
//     return (number);
// }

// // Генерация случайного 2D массива.
// int[,] Gen2DArr(int countRow, int countColumn, int arrMin, int arrMax)
// {
//     int[,] arr2D = new int[countRow, countColumn];
//     Random rnd = new Random();

//     if (arrMin > arrMax)
//     {
//         int temp = arrMax;
//         arrMax = arrMin;
//         arrMin = temp;
//     }

//     for (int i = 0; i < arr2D.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr2D.GetLength(1); j++)
//         {
//             arr2D[i, j] = rnd.Next(arrMin, arrMax);
//         }
//     }
//     return arr2D;
// }

// // Печатает двумерный массив в цвете по диоганали.
// void Print2DArrayDigonalColor(int[,] array, int bias = 0)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.ForegroundColor = GetColorСell(i + bias, j);
//             Console.Write(array[i, j] + " ");
//             Console.ResetColor();
//         }
//         Console.WriteLine();
//     }
// }

// // Задает цвет ячейки.
// // Принимает индексы, возвращает цвет.
// ConsoleColor GetColorСell(int i, int j)
// {
//     ConsoleColor[] col = new ConsoleColor[]
//     {
//         ConsoleColor.Black,
//         ConsoleColor.Blue,
//         ConsoleColor.Cyan,
//         ConsoleColor.DarkBlue,
//         ConsoleColor.DarkCyan,
//         ConsoleColor.DarkGray,
//         ConsoleColor.DarkGreen,
//         ConsoleColor.DarkMagenta,
//         ConsoleColor.DarkRed,
//         ConsoleColor.DarkYellow,
//         ConsoleColor.Gray,
//         ConsoleColor.Green,
//         ConsoleColor.Magenta,
//         ConsoleColor.Red,
//         ConsoleColor.White,
//         ConsoleColor.Yellow
//     };

//     int numCol = (j - i) % col.Length;
//     if (numCol < 0)
//         numCol = col.Length + numCol;
//     return col[numCol];
// }

// // Считает среднее арифметическое по столбцам.
// double[] AverageСolumn(int[,] array2D)
// {
//     double[] arrayAverage = new double[array2D.GetLength(1)];
//     int sum = 0;

//     for (int j = 0; j < array2D.GetLength(1); j++)
//     {
//         for (int i = 0; i < array2D.GetLength(0); i++)
//         {
//             sum += array2D[i, j];
//         }
//         arrayAverage[j] = Math.Round((double)sum / array2D.GetLength(0), 2);
//         sum = 0;
//     }
//     return arrayAverage;
// }

// // Считает среднее арифметическое по диоганали.
// double[] AverageDioganal(int[,] array2D)
// {
//     double[] arrayAverage = new double[array2D.GetLength(0) + array2D.GetLength(1) - 1];
//     int sum = 0;
//     int iStart = array2D.GetLength(0) - 1;
//     int iFinish = array2D.GetLength(0);
//     int jStart = 0;
//     int j = 0;
//     int n = 0;

//     for (int k = 0; k < array2D.GetLength(0) + array2D.GetLength(1) - 1; k++)
//     {
//         for (int i = iStart; i < iFinish; i++)
//         {
//             sum = sum + array2D[i, j];
//             n++;
//             j++;
//         }

//         iStart--;
//         if (iStart < 0)
//         {
//             iStart = 0;
//             jStart++;
//         }
//         if (j > array2D.GetLength(1) - 1)
//             iFinish--;

//         j = jStart;
//         arrayAverage[k] = Math.Round((double)sum / n, 2);
//         sum = 0;
//         n = 0;
//     }

//     return arrayAverage;
// }

// // Печатает одномерный массив в цвете по последней строке массива.
// void Print1DArrayColor(string message, double[] array, int row)
// {
//     int i;
//     Console.Write(message);
//     for (i = 0; i < array.Length - 1; i++)
//     {
//         Console.ForegroundColor = GetColorСell(row - 1, i);
//         Console.Write(array[i] + " ");
//         Console.ResetColor();
//     }
//     Console.ForegroundColor = GetColorСell(row - 1, i);
//     Console.WriteLine(array[array.Length - 1]);
//     Console.ResetColor();
// }

// int row = ReadData("Введите количество строк ");
// int column = ReadData("Введите количество столбцов ");

// int[,] arr2D = Gen2DArr(row, column, 10, 100);
// Print2DArrayDigonalColor(arr2D);

// Print1DArrayColor("Среднее арифметическое по столбцам: ", AverageСolumn(arr2D), row);
// Print1DArrayColor("Среднее арифметическое по диогонали: ", AverageDioganal(arr2D), row);

//  DateTime time = DateTime.Now; // Радуга диоганальная
// int n = 0;
// Console.Clear();
// while (true)
// {
//     if ((DateTime.Now - time) > TimeSpan.FromMilliseconds(100))
//     {
//         Console.SetCursorPosition(0, 0);
//         arr2D = Gen2DArr(row, column, 10, 100);
//         Print2DArrayDigonalColor(arr2D, n);
//         n++;
//         time = DateTime.Now;
//     }
// } 

// // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// //Метод считывает введенную пользователем информацию
// int ReadData(string line)
//  {
//      Console.Write(line);
//      int number = int.Parse(Console.ReadLine() ?? "0");
//      return number;
//  }

// // Универсальный метод генерации и заполнение двумерного массива
//  int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
//  {
//      System.Random rand = new System.Random();
//      int[,] array2D = new int[countRow, countColumn];

//      for (int i = 0; i < countRow; i++)
//      {
//          for (int j = 0; j < countColumn; j++)
//          {
//              array2D[i, j] = rand.Next(topBorder, downBorder + 1);
//          }
//      }
//      return array2D;
//  }

// //Метод печати двумерного массива в цвете
// void Print2DArrayColor(int[,] matrix)
//  {
//      ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
//                                          ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
//                                          ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
//                                          ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
//                                          ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
//                                          ConsoleColor.Yellow};

//      for (int i = 0; i < matrix.GetLength(0); i++)
//      {
//          for (int j = 0; j < matrix.GetLength(1); j++)
//          {
//              Console.ForegroundColor = col[new System.Random().Next(0,16)];
//              Console.Write(matrix[i, j]+"     ".Substring(matrix[i, j].ToString().Length));
//              Console.ResetColor(); 
//              System.Threading.Thread.Sleep(100);//Пауза после выполнения действий внутри цикла J на 100мс
//          }
//          Console.WriteLine();
//      }
//  }

// //Метод поиска среднего арифметического среди всех элементов в столбце
//  double[] AvgCol(int[,] arr)
//  {
//     double[] avg = new double[arr.GetLength(1)];
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//            avg[j]+=arr[i,j];
//         }
//         avg[j] = Math.Round(avg[j]/arr.GetLength(0),1);
//     }
//     return avg;
//  }

// //Вывод одномерного массива в консоль
// void Print1DArr(double[] arr)
//  {
//      for (int i = 0; i < arr.Length - 1; i++)
//      {
//          Console.Write(arr[i] + ", ");
//      }
//      Console.WriteLine(arr[arr.Length - 1]);
//  }

// int row = ReadData("Введите количество строк: ");
// int column = ReadData("Введите количество столбцов: ");
// int[,] arr2D = Fill2DArray(row, column, 10, 99);
// Print2DArrayColor(arr2D);
// double[] avg = AvgCol(arr2D);
// Print1DArr(avg);