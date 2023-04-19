// Задача 27: Напишите программу, которая принимает на вход число
//и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

 if (number < 0) //Проверка, если число будет введено отрицательным
 {
     number = - number;
 }

int sumDigits = SumDigits(number);

Console.WriteLine($"Сумма цифр в числе: {number} -> {sumDigits}");

int SumDigits(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + num % 10 - 1;
        num = num / 10;
        res++;
    }
    return res;
}