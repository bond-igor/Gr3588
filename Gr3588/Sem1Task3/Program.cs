string? inputLine = Console.ReadLine();

// Проверяем чтобы данные были не пустыми
if(inputLine!=null)
{
    //Создаем массив с днями недели
    string[] dayOfWeek = new string[7];
    dayOfWeek[0] = "Понедельник";
    dayOfWeek[1] = "Вторник";
    dayOfWeek[2] = "Среда";
    dayOfWeek[3] = "Четверг";
    dayOfWeek[4] = "Пятница";
    dayOfWeek[5] = "Суббота";
    dayOfWeek[6] = "Восресенье";

    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);

//Находим название дня недели
    string outDayOfWeek = dayOfWeek[inputNumber - 1];
 
//Выводим данные в консоль
Console.WriteLine(outDayOfWeek);
}