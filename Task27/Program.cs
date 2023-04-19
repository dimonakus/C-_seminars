// Задача 27: Напишите программу, которая принимает на вход число
//и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigits = SumDigits(number);

Console.WriteLine($"Сумма цифр в числе: {number} -> {sumDigits}");

int SumDigits(int num)
{
    int count = 0;
    while (num > 0)
    {
        count = count + num % 10 - 1;
        num = num / 10;
        count++;
    }
    return count;
}