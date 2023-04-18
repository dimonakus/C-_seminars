// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int runkNumber = GetRank(number);
Console.WriteLine($"{runkNumber}");

int GetRank(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count++;    //count = count + 1;
    }
    return count;
}

//Пример решения коллег

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int length = Length(number);
// Console.WriteLine(length);
// int Length(int num)
// {
//    int count = 0;
//    while (num>0)
//    {
//       num /= 10;
//       count++;
//    }
//    return count;
// }