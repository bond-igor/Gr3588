// Получаем значения от пользователя
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();

// Проверяем чтобы данные были не пустыми
if(inputLineA!=null&&inputLineB!=null&&inputLineC!=null)
{
    //Парсим введенное число
    int numA = int.Parse(inputLineA);
    int numB = int.Parse(inputLineB);
    int numC = int.Parse(inputLineC);
    
    //Сравниваем значения введенных чисел и выводим результат
    Console.WriteLine("max=" +Math.Max(Math.Max(numA, numB), Math.Max(numB, numC)));
    
}