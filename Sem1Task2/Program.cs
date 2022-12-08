// Получаем значения от пользователя
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

// Проверяем чтобы данные были не пустыми
if(inputLineA!=null&&inputLineB!=null)
{
    //Парсим введенное число
    int numA = int.Parse(inputLineA);
    int numB = int.Parse(inputLineB);
    
    //Сравниваем значения введенных числе
    if(numA>numB)
    
    //Выводим результат
    {
        Console.WriteLine($"{numA} больше чем {numB}");
    }
    else
    {
    Console.WriteLine($"{numB} больше чем {numA}");
    }
}
