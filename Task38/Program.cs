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
double maxIElementRound = Math.Round(array.Max(), 1);

void SubtractionMaxMin(double min, double max)
{
double subtractionMaxMin = Math.Round((maxIElementRound - minIElementRound), 1);
Console.Write($"{subtractionMaxMin}");
}

Console.Write("[");
PrintArray(array);
Console.Write("] -> ");
SubtractionMaxMin(minIElementRound, maxIElementRound);




//======================== Черновики
// void MinIElement(double[] arr)
// {
//     //int b = 0;
//     //double min = arr[b];
//     //double roundMin = Math.Round(arr[b], 1);
//     for (int i = 0; i < arr.Length-1; i++)
//     {
//         double min = arr[i];
//         double roundMin = Math.Round(min, 1);

//         for (int j = i + 1; j < arr.Length; j++)
//         {
//         if (arr[j] < min) min = arr[j];
//         }

//         //if (min>arr[i]) min = arr[i];
//         //return roundMin;
//          //Console.Write($"{min}, ");
//     }
       
// }


// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }        


//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// int maxDigit(int num) // num = number
// {
//     int firstDigit = num / 10;
//     int secondDigit = num % 10;
//     int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
//     return maxDigit;
// }


// double MaxIDigit(double[] arr)
// {
//     int i = 0;
//     double maxIDigit = arr[i];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i]>maxIDigit) maxIDigit = Math.Round(arr[i], 1);
//     }
//     return maxIDigit;
// }

// double SubtractionMaxMin(double min, double maxIDigit)
// {
//     double subtractionMaxMin = Math.Round((maxIDigit - minIDigit), 1);
//     return subtractionMaxMin;
// }