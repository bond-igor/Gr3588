// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int prefix)
{
    Console.WriteLine(prefix);
}

int SumRecMN(int M, int N)
{
    int outRes = 0;
    if (M >= N) return N;
     outRes = M + SumRecMN(M + 1, N);
    return outRes;
}

//___ПРОГРАММА___
int number1 = ReadData("Введите число M: ");
int number2 = ReadData("Введите число N: ");
int resultLine = SumRecMN(number1, number2);
PrintResult(resultLine);

