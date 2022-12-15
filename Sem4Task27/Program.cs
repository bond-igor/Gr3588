// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//___МЕТОДЫ___

//запрос данных у пользователя
int ReadData(string msg)
{
    //выводим сообщение
    Console.Write(msg);
    //считываем число
    return int.Parse(Console.ReadLine() ?? "0");//возвращаем значение
  }

// Метод вывода результата
void PrintResult(string sum)
{
   Console.WriteLine(sum);
}
//Метод вычисляет сумму цифр
int SumDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum +=num%10;
        num = num/10;
    }
    return sum;
}

//___ПРОГРАММА___

int num = ReadData("Введите число: ");
int sum = SumDigits(num);
PrintResult("Сумма цифр в числе = " +sum);
