// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = -number;
}
if (number >= 9999 && number <= 99999)
{

    bool result = Polindrom(number);
    Console.WriteLine(result ? $"{number} -> да" : $"{number} -> нет");
}
else
{
    Console.Write("Вы ввели не пятизначное число");
}

bool Polindrom(int num)
{
    return (num / 10000 % 10 == num % 10) && (num / 1000 % 10 == num / 10 % 10);
}