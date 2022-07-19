/*
Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
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
/*
int[,] InitMatrix(int m)
{
    int[,] matrix = new int[m, m];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
        for (int j = 0; j < m; j++) matrix[i, j] = rand.Next(m, m+1);
    for (int currentChar = 1, padding = 0; padding < m / 2; padding++)
    {
        for (int j = padding; j < m - padding; j++)
            matrix[padding, j] = currentChar;
        for (int j = padding; j < m - padding; j++)
            matrix[m - padding - 1, j] = currentChar;
        for (int i = padding + 2; i < m - padding - 1; i++)
            matrix[i, padding] = currentChar;
        for (int i = padding + 1; i < m - padding - 1; i++)
            matrix[i, m - padding - 1] = currentChar;
        currentChar = 1 - currentChar;
        matrix[padding + 1, padding] = currentChar;
    }
    if (m % 2 != 0 && matrix[0, 0] == 1) matrix[m / 2, m / 2] = 1; return matrix;
}
*/



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

int m = GetNumber("Введите размерность матрицы m:");

int[,] matrix = InitMatrix(m);
Console.WriteLine();
Console.WriteLine($"Матрица размером {m}x{m}:");
Console.WriteLine();

PrintMatrix(matrix);