// Получаем значения от пользователя
string? inputLineA = Console.ReadLine();

// Проверяем чтобы данные были не пустыми
if(inputLineA!=null)
{
    //Парсим введенное число
    int numA = int.Parse(inputLineA);
        
    // Проверяем на четность
    if(numA%2 == 0)
    
    //Выводим результат
    {
        Console.WriteLine("Четное");
    }
    else
    {
    Console.WriteLine("Нечетное");
    }
}