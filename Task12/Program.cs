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

//Вариант описания условия обычным способом  
if (result == 0) Console.Write ($"{number1},{number2} -> кратно");
else Console.Write ($"{number1},{number2} -> не кратно, остаток {result}");

//Второй вариант описания тернарным условием
//string res = result == 0 ? $"{number1},{number2} -> кратно" : $"{number1},{number2} -> не кратно, остаток {result}";
//Console.Write(res);

int Remainder(int num1, int num2)
{
    return num1 % num2;
}