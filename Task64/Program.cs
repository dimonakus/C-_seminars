// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {number} -> ");
NaturalToOne(number);

void NaturalToOne(int num)
{

    if (num < 0) Console.WriteLine("Ошибка, вы ввели отрицательное число");

    else if (num > 0)
    {

        Console.Write($"{num}, ");
        NaturalToOne(num - 1);
    }
}