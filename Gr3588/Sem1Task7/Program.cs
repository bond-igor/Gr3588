string? inputLine = Console.ReadLine();

// Проверяем чтобы данные были не пустыми
if(inputLine!=null)
{
    int inputNumber = int.Parse(inputLine);
    int lastDigit = inputNumber%10;
    Console.WriteLine(lastDigit);
}
