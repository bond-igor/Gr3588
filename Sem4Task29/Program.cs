// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//___МЕТОДЫ___

//запрос данных у пользователя
string ReadData(string msg)
{
    //выводим сообщение
    Console.WriteLine(msg);
    //считываем число
    return Console.ReadLine() ?? "0";//возвращаем значение
  }

// Метод вывода результата
void PrintResult(string arr)
{
   Console.WriteLine(arr);
}

//Метод преобразовывает строку в массив
string Array(string num)
{
    string [] arr = num.Split(",");
    return arr;
}

//___ПРОГРАММА___

string num = ReadData("Введите числа через запятую");
string arr = Array(num);
PrintResult("Массив чисел " +arr);