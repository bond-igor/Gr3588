// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//___МЕТОДЫ_____

//запрос данных у пользователя
int ReadData(string msg)
{
    //выводим сообщение
    Console.Write(msg);
    //считываем число
    return int.Parse(Console.ReadLine() ?? "0");//возвращаем значение
  }

// Метод вывода результата
void PrintResult(string res)
{
   Console.WriteLine(res);
}

//Метод вычисления степени
int CalcPow(int num, int pownum)
{
    int res = (int)Math.Pow(num, pownum);
    return res;
}

//___ПРОГРАММА___

int num = ReadData("Введите число: ");
int pownum = ReadData("Введите степень числа: ");
int res = CalcPow(num, pownum);
PrintResult($"Число {num} в степени {pownum} = {res}");
