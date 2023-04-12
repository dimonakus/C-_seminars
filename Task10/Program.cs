// Задача 10. Напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает вторую цифру этого числа

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = secondDigit(number);
Console.WriteLine(number >= 100 && number <= 999 ? $"Вторая цифра трехзначного числа {result}" : $"{number} не является трезначным числом");

int secondDigit(int num) // num = number
{
    int firstDigit = num / 10;
    return firstDigit % 10;
}
