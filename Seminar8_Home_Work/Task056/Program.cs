/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = randomizer.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void MaxSumRowInMatrix(int[,] matrix)
{
    int rowSum = 0;
    int rowMinSum = 0;
    int minRow = 0;
    for (int k = 0; k < matrix.GetLength(1); k++)
    {
        rowSum += matrix[0, k];
    }
    rowMinSum = rowSum;

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        rowSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }
        if (rowSum < rowMinSum)
        {
            rowMinSum = rowSum;
            minRow = i;
        }
    }
    Console.WriteLine($"Сумма элементов {minRow + 1}-ой строки минимальна и равна {rowMinSum}");
}

int m = GetNumber("Введите число строк массива m:");
int n = GetNumber("Введите число столбцов массива n:");

int[,] matrix = InitMatrix(m, n);
Console.WriteLine();
Console.WriteLine($"Матрица размером {m}x{n}:");
Console.WriteLine();

PrintMatrix(matrix);
Console.WriteLine();
MaxSumRowInMatrix(matrix);