// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write ("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = Remainder(number1, number2);

if (result == 0) Console.Write ($"{number1},{number2} -> кратно");
else Console.Write ($"{number1},{number2} -> не кратно, остаток {result}");

int Remainder(int num1, int num2)
{
    return num1 % num2;
}


// int multipleNumber (int num1, num2) // num = number
// {
//     if (num1 % num2 == 0) Console.WriteLine($"first number {number1} is multiple of second number {number2}");
//     else
//     int ost = num1 % num2;
//     return ost;
// }
// Console.WriteLine("");

