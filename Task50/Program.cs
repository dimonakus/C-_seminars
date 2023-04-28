﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


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

void CheckElement(int[,] matrix, int row, int column)
{
    if (row > 0 && row <= matrix.GetLength(0) &&
        column > 0 && column <= matrix.GetLength(1))
    {
        Console.WriteLine($"{row}, {column} -> {matrix[row - 1, column - 1]} ");
    }
    else Console.WriteLine($"{row}, {column} -> такого элемента нет в масиве");

}

Console.WriteLine("Введите номер искомой строки: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер искомого столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);
CheckElement(array2d, row, column);