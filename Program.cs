
 /*Задача 47. Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
min = 5
max = 9
double p = new Random().NextDouble()*(max-min)+min*/

// Random.NextDouble returns a double between 0 and 1. You then multiply that by the range you need to go into (difference between maximum and minimum) and then add that to the base (minimum).

// double p = new Random().NextDouble()*(max-min)+min

using System;
using static System.Console;

Clear();
PrintArray (GetArray(10,10, 0.2, 5.5));

double [,] GetArray(int m, int n, double min, double max)
{
    double [,] result = new double [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*(max-min)+min;
        }

    }
    return result;
}


void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}












      














 