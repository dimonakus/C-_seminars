// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(99, 1000); //99 + 1
Console.WriteLine($"Случайное число из отрезка 99 - 1000 -> {number}");


int DeleteCenterDigit(int num) // num = number
{
    int first = num / 100;
    int third = num % 10;
    int answer = first * 10 + third;
    return answer;
}
Console.WriteLine($"Двузначное число -> {DeleteCenterDigit(number)}");
