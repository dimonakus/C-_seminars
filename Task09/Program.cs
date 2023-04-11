// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8 78 % 10 = 70/10 + 8
// 12-> 2
// 85 -> 8



int number = new Random().Next(10, 100); //99 + 1
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if(firstDigit > secondDigit) Console.WriteLine($"Наибальшая цифра числа {number} -> {firstDigit}");
// else 
// Console.WriteLine($"Наибальшая цифра числа {number} -> {secondDigit}");

//int maxDigit = firstDigit > secondDigit ? firstDigit : firstDigit; // ? - тогда, : - иначе
//Console.WriteLine($"Наибальшая цифра числа {number} -> {maxDigit}");

int maxDigit2 = maxDigit(number);
Console.WriteLine($"Наибальшая цифра числа {number} -> {maxDigit2}");

int maxDigit(int num) // num = number
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}