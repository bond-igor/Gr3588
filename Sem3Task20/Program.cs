int coordX1 = ReadData("Введите координату X1: ");
int coordY1 = ReadData("Введите координату Y1: ");
int coordX2 = ReadData("Введите координату X2: ");
int coordY2 = ReadData("Введите координату Y2: ");

PrintData("Растояние между точками: ", CalculyteLength(coordX1, coordY1, coordX2, coordY2));

//Метод читает данные пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

//Метод находит расстояние между точками на плоскости
double CalculyteLength(int coordX1,int coordY1,int coordX2,int coordY2)
{
    double res = Math.Sqrt(Math.Pow((coordX1-coordX2),2) + Math.Pow((coordY1-coordY2),2));
    return res; 
}

//Метод выводит данные пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}