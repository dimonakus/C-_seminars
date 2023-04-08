// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите порядковый номер дня недели");
int number_day_of_week = Convert.ToInt32(Console.ReadLine());
if (number_day_of_week == 1)
{
    Console.WriteLine("Понедельник");
}
else if (number_day_of_week == 2)
{
    Console.WriteLine("Вторник");
}
else if (number_day_of_week == 3)
{
    Console.WriteLine("Среда");
}
else if (number_day_of_week == 4)
{
    Console.WriteLine("Четверг");
}
else if (number_day_of_week == 5)
{
    Console.WriteLine("Пятница");
}
else if (number_day_of_week == 6)
{
    Console.WriteLine("Суббота");
}
else if (number_day_of_week == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Нет такого дня в неделе");
}