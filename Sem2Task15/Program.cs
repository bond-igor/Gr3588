// Ввод числа пользователем
int numberDay = int.Parse(Console.ReadLine()??"0");

//Проверяем чтобы число не выходило за диапазон кол-ва дней недели
if(numberDay > 0 && numberDay < 8)
{
    // Проверяем является ли введенное значение выходным днем
    if(numberDay > 5)

    // Выводим результат
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}
else
{
     Console.WriteLine("Введите число от 1 до 7");
}