
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

// using System;
// using static System.Console;

// Clear();
// PrintArray (GetArray(10,10, 0.2, 5.5));

// double [,] GetArray(int m, int n, double min, double max)
// {
//     double [,] result = new double [m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble()*(max-min)+min;
//         }

//     }
//     return result;
// }


// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Write($"{array[i, j]} ");
//         }
//         WriteLine();
//     }
// }










 /*Задача 50. Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1, 7] -> такого числа в массиве нет*/


// using System;
// using static System.Console;


// Write("Введите номер строки ");
// int rows = int.Parse(ReadLine());

// Write("Введите номер столбца ");
// int columns = int.Parse(ReadLine());

// Clear();
// PrintArray (GetArray(5, 5, 0, 10), rows, columns);


// int [,] GetArray(int m, int n, int min, int max)
// {
//     int [,] result = new int [m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max+1);
//         }

//     }
//     return result;
// }


// void PrintArray(int[,] array, int x, int y)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Write($"{array[i, j]} ");
//         }
//         WriteLine();
//     } 
    
    
//     WriteLine();
//     if (x<array.GetLength(0) && y<array.GetLength(1))
//     WriteLine($"{array[x, y]} ");
//     else WriteLine("Такого числа нет");
// }

      














 /*Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


using System;
using static System.Console;

Clear();
PrintArray (GetArray(5, 5, 0, 10));

int [,] GetArray(int m, int n, int min, int max)
{
    int [,] result = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max+1);
        }

    }
    return result;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    } 


    int k=0;
    int m=1;
    int size = array.GetLength(1);
        int [] sum = new int [size];
        int [] summ = new int [size];
     for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {   Write($"{array[i, j]} "); 
            sum [k] = array[i,j]; 
            k++;
            
        }
        summ[m]*=sum[k];
        WriteLine();
    } 
    Write($"{sum[k]} "); 
    Write($"{summ[m]} "); 
}

// Write($"{array[i, j]} "); 

// int a = array[i, j+1]*array[i, j+1];


// int GetSumDiag(int[,] array)
// {
//     int length = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
//     int sum = 0;
//     for (int i = 0; i < length; i++)
//     {
//         sum *= array[i, i];
//     }
//     return sum;
// }