﻿// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] result = Fibonacci(number);
//Console.WriteLine(result);
ArrayPrint(result);

int[] Fibonacci(int num)
{
    int[] array = new int[num];
    //if (num == 1 num == 2) return 1;
    //else
    //array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void ArrayPrint(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
            Console.Write($"{array[i]} ");
   }
}