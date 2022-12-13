//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//запрос  числа от пользователя
int num = ReadData("Введите пятизначное число: ");

// Программа
bool cornum = CorrectNum(num);
    if(!cornum) PrintData("Вы ввели не пятизначное число");
    else 
    {
        bool res = PalinTest(num);
        if(res) PrintData("Это палиндром");
        if(!res) PrintData("Это не палиндром");
    }

//МЕТОДЫ

//Метод читает данные пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод проверяет корректность введеного числа
bool CorrectNum(int num)
{
    bool cornum = (num > 9999 && num < 100000);
    
    return cornum;
}
//Метод делает проверку является ли число палиндромом
bool PalinTest(int num)
{
    bool res = (num/10000 == num%10) && ((num/1000)%10) == ((num/10)%10);

    return res;
}

//Метод выводит данные пользователю
void PrintData(string msg)
{
    Console.WriteLine(msg);
}