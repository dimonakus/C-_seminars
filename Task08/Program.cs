﻿//Задача 8: Напишите программу, которая на вход
//принимает число (N), а на выходе показывает все чётные
//числа от 1 до N.

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= numberA)
{
    if (count % 2 == 0) Console.Write(count + ", ");
    count++;
}