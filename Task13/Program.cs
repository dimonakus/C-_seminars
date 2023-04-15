// // Задача 13. Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
//645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int Prompt(string message);
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result =Convert.ToInt32(value);
//     return result;
// }

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100)
{
    int result = GetThirdRank(number);
    Console.WriteLine($"{number} -> {result}");
}
else
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}

int GetThirdRank(int num)
{
    int count = num;
    while (num > 999)
    {
        num = num / 10;
        count++;    //count = count + 1;
    }
    return num % 10;
}