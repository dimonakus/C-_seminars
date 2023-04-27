// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Считать число с консоли
int Prompt (string message)
{
    Console.Write(message); //Выводит сообщение
    string value = Console.ReadLine(); // Считывает с консоли строку
    int result = Convert.ToInt32(value); // Преобразует строку в целое число
return result; // Возвращает результат
}
// Метод ввода массива

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i <array.Length; i++)
    {
        array[i] = Prompt($"Введите {i +1}-й элемент");
    }
    return array;
}

// Метод выводящий на печать
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

// Метод, подсчитывающий кол-во положительных элементов в массиве
int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = Prompt("Введите количество элементов: ");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 -> {CountPositiveNumbers(array)}");