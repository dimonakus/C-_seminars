// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите Первое целое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе целое число");
int number2 = Convert.ToInt32(Console.ReadLine());
//int number2 = Math.Mod(number2);
Console.WriteLine("А теперь я проверю, является ли первое число квадратом второго");
//double square_root = Math.Sqrt(number1);
if (number2*number2 == number1)
{
    Console.WriteLine($"Да, число {number1} является квадратом числа {number2}");
}
else
    Console.WriteLine($"Нет, число {number1} НЕ является квадратом числа {number2}");