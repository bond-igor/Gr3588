int numN = ReadData("Введите число: ");

string outoutline = outlineBilder(numN, 1);

PrintData(" ", outoutline);

outoutline = outlineBilder(numN, 2);

PrintData(" ", outoutline);

//Метод читает данные пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод выводит результат в виде строки значений
string outlineBilder(int numN, int Pow)
{
    string outline = string.Empty;
    for (int i = 1; i < numN; i++)
    {
        outline = outline + Math.Pow(i, Pow) + " ";
    }
    outline = outline + Math.Pow(numN, Pow);
    return outline;
}

//Метод выводит данные пользователю
void PrintData(string msg, string outline)
{
    Console.WriteLine(msg + outline);
}