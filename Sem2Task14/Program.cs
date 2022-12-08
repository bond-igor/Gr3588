int number = int.Parse(Console.ReadLine()??"0");


int result1 = number%7;
int result2 = number%23;

if((result1 == 0) && (result2 == 0))
{
    Console.WriteLine("Да");
}
else
{
     Console.WriteLine("Нет");
}