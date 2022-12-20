// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//___МЕТОДЫ___
//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

//Метод считает колличество положительных чисел
int CountPositiveNum(int num)
{
    int res = 0;
    while(num > 0)
    {
        if (ReadData("Введите число") > 0) res++;
        num = num - 1;
    }
    return res;
}

//___ПРОГРАММА___
int num = ReadData("Введите общее колличество чисел ");
int res = CountPositiveNum(num);
PrintData("Колличество положительных чисел ", res);