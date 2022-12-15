// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//___МЕТОДЫ___

//запрос данных у пользователя
int ReadData(string msg)
{
    //выводим сообщение
    Console.WriteLine(msg);
    //считываем число
    return int.Parse(Console.ReadLine() ?? "0");//возвращаем значение
}

// Метод вывода результата
void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArr(arr);
}

//Метод создает массив в заданном диапазоне
int[] GenArr(int num1, int num2)
{
    Random rnd = new Random();
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(num1, num2);
    }
    return arr;
}

//Метод добавляет [] и запятые
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}


//___ПРОГРАММА___

int num1 = ReadData("Введите первое число диапазона.");
int num2 = ReadData("Введите второе число диапазона.");

int[] arr = GenArr(num1, num2);

PrintData("Сгененрированный массив:",arr);