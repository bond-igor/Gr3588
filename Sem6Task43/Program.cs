// №43 Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//___МЕТОДЫ___
//Метод, считывающий данные, введенные пользователем
double ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

//Метод вычисляет координату точки пересечения прямых
double CalcCoordX(double b1, double k1, double b2, double k2)
{
    double x = ((b2 - b1) / (k1 - k2));
    return x;
}

double CalcCoordY(double x, double b2, double k2)
{
    double y = (k2*x + b2);
    return y;
}

//___ПРОГРАММА___
double b1 = ReadData("Введите b1 ");
double k1 = ReadData("Введите k1 ");
double b2 = ReadData("Введите b2 ");
double k2 = ReadData("Введите k2 ");
double coordX = CalcCoordX(b1,k1,b2,k2);
double coordY = CalcCoordY(coordX, b2,k2);
PrintData($"Координаты точки пересечения прямых: ({coordX}:{coordY})");