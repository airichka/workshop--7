﻿/* адача 47. Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

double[,] array = new double [5,5];
for (int i = 0; i < array.GetLength(0); i++ )
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array [i, j] = new Random().Next(200) / 10.0 -10;
        Console.Write($"{array[i, j]}" );
    }
    Console.WriteLine();
    }

