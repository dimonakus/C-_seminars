﻿// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int powNumbers = PowNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} -> {powNumbers}");

int PowNumbers(int num) //int num = number
{
    int pow = 1;
    for (int i = 1; i <= num; i++)
    {
        checked // Проверка на переполнение
        {

        
        pow = pow * i; //sum+=i;
                       //
        }                
    }
    return pow;
}

//Решения коллег