// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(99, 1000); //99 + 1
Console.WriteLine($"Случайное число из отрезка 99 - 1000 -> {number}");


// int maxDigit (int num) // num = number
// {
//     int firstDigit = num / 100;
// int secondDigit = num % 10;

// int maxDigit = firstDigit > secondDigit ? firstDigit : firstDigit;
// return maxDigit;
// }

