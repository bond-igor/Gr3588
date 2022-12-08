int number1 = int.Parse(Console.ReadLine()??"0");
int number2 = int.Parse(Console.ReadLine()??"0");

bool result1 = (number1/number2 == number2);
bool result2 = (number2/number1 == number1);

if(result1) Console.WriteLine("Первое число является квадратом второго");
if(result2) Console.WriteLine("Второе число является квадратом первого");
if(!result1&&!result2) Console.WriteLine("Числа не являются квадратом друг друга");