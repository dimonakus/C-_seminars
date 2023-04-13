// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет является ли этот день выходным.

Console.WriteLine("Введите порядковый номер дня недели");
int number_day_of_week = Convert.ToInt32(Console.ReadLine());

bool result = IsDayOfWeekEnd(number_day_of_week);


if (number_day_of_week > 7||number_day_of_week<1)
{
    Console.WriteLine("Нет такого дня в неделе");
}
else
{
   Console.WriteLine(result ? $"День на неделе {number_day_of_week} - выходной" : $"День на неделе {number_day_of_week} - не выходной"); 
}


bool IsDayOfWeekEnd(int num)
{
    return (num == 6) || (num == 7);
}