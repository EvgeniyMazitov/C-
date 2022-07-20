/*
Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.

Умножение поэлементное. Умножение по правилам математического умножения матриц уже делали на семинаре. 

Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
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

int[,] MultiMatrix(int[,] matrix1, int[,] matrix2, int m, int n)
{
    int[,] resultMatrix = new int[m, n];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            resultMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return resultMatrix;
}

int m = GetNumber("Введите число строк массива m:");
int n = GetNumber("Введите число столбцов массива n:");

int[,] matrix1 = InitMatrix(m, n);
int[,] matrix2 = InitMatrix(m, n);
Console.WriteLine();
Console.WriteLine($"Матрицы размером {m}x{n}:");
Console.WriteLine();
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
Console.WriteLine($"Матрица произведений элементов двух матриц:");
int[,] resultMatrix = MultiMatrix(matrix1, matrix2, m, n);
Console.WriteLine();
PrintMatrix(resultMatrix);