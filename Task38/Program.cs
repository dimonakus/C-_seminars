// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double round = Math.Round(arr[i], 1);
        if (i < arr.Length - 1) Console.Write($"{round}, ");
        else Console.Write($"{round}");
    }
}

double[] array = CreateArrayRndDouble(6, 0, 10);
double minIElementRound = Math.Round(array.Min(), 1);
//Вариант II (более правильный с точки зрения образовательного процесса)
// double minIElementRound (double[] arr)
// {
//     double min = arr[0];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         double round = Math.Round(arr[i], 1);
//         if(round < min) min = round; 
//     }
//     return min;
// }
double maxIElementRound = Math.Round(array.Max(), 1);
//Вариант II (более правильный с точки зрения образовательного процесса)
// double maxIElementRound (double[] arr)
// {
//     double max = arr[0];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         double round = Math.Round(arr[i], 1);
//         if(round > max) max = round; 
//     }
//     return max;
// }


void SubtractionMaxMin(double min, double max)
{
double subtractionMaxMin = Math.Round((maxIElementRound - minIElementRound), 1);
Console.Write($"{subtractionMaxMin}");
}

Console.Write("[");
PrintArray(array);
Console.Write("] -> ");
SubtractionMaxMin(minIElementRound, maxIElementRound);