// Получаем значения от пользователя
string? inputLineN = Console.ReadLine();

// Проверяем чтобы данные были не пустыми
if(inputLineN!=null)
{
    //Парсим введенное число
    int numN = int.Parse(inputLineN);

    //Добавляем точку отсчета
    int numC = 2;

    //Создаем накопитель результата
    string res = string.Empty;

    // Запускаем счетчик четных чисел
    while (numC < numN + 1)
    {
        // Добавляем следующее число к результату
        res = res + numC + ", ";

        // Переходим к следующему четному числу
        numC = numC + 2;
    }        

    //Выводим результат
    Console.WriteLine(res);
        
}