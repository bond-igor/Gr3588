// Ввод числа пользователем
int number = int.Parse(Console.ReadLine()??"0");

// Делаем проверку, что введенное число имеет три символа
if(number > 99)
{
    // Находим количество цифр в числе
    int quantity =(int)(Math.Log10(number) - 2);
   
    //Находим третью цифру
    int result = number/(int)((Math.Pow(10, quantity)))%10;
   
    //выводим результат
    Console.WriteLine("третье число " + result);
}
else
{
    // Если проверка не пройдена, запрашиваем новое число.
    Console.WriteLine("В веденном числе менее трех символов");
}