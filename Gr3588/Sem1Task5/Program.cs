string? inputLine = Console.ReadLine();

// Проверяем чтобы данные были не пустыми
if(inputLine!=null)
{

    //Парсим введенное число
    int inputNumber = int.Parse(inputLine);
    int startNumber = inputNumber*(-1);

    //Выходное значение
    string outline = string.Empty;

    while(startNumber<inputNumber)
    {
        outline = outline + startNumber + ", ";
        startNumber++;
    }
    outline = outline + inputLine;

    //Выводим данные в консоль
    Console.WriteLine(outline);
}
