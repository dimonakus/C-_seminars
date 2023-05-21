// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");

int[,] resultMatrix = new int[rows, columns];
int min = 1;
int max = 9;

int[,] firstMatrix = CreateMatrixRndInt(rows, columns, min, max);
int[,] secondMatrix = CreateMatrixRndInt(rows, columns, min, max);

//Матрицу 1 можно умножить на матрицу 2 только в том случае, если число столбцов матрицы 1 равняется числу строк матрицы 2.
//Матрицы, для которых данное условие не выполняется, умножать нельзя

if (firstMatrix.GetLength(0) != secondMatrix.GetLength(1))
{
    Console.WriteLine("С матрицами таких параметров нельзя произвести действия умножения");
    return;
}

//Умножение матриц осуществляется путем умножения строки на столбец.
//Находятся произведения первого элемента строки и первого элемента столбца, второго элемента строки и второго элемента столбца и т.д.
//Затем полученные произведения суммируются

for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < firstMatrix.GetLength(1); k++)
        {
            resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
    }
}

// Метод ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Метод заполнения массива рандомными числами от min до max (объявляются отдельно)
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

// Функция вывода массива в терминал 
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine(" |");
    }
}

Console.WriteLine("Первый массив");
PrintMatrix(firstMatrix);
Console.WriteLine();

Console.WriteLine("Второй массив");
PrintMatrix(secondMatrix);
Console.WriteLine();

Console.WriteLine("Результат умножения двух массивов");
PrintMatrix(resultMatrix);
