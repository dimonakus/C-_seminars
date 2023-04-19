// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

int[] array = new int[8];
ArrayIn(array);
ArrayPrint(array);
Console.Write("\b\b");
Console.Write(" -> [");
ArrayPrint(array);
Console.Write("\b\b");
Console.Write("]");

void ArrayIn(int[] array)
{
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 101);
    }
}

void ArrayPrint(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}