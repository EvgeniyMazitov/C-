/*
Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
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

void ChangStringMatrix(int[,] matrix)
{
    int buffer = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        buffer = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0)-1, j];
        matrix[matrix.GetLength(0)-1, j] = buffer;
    }
}

int m = GetNumber("Введите число строк массива m:");
int n = GetNumber("Введите число столбцов массива n:");

int[,] matrix = InitMatrix(m, n);
Console.WriteLine();
Console.WriteLine($"Матрица размером {m}x{n}:");
Console.WriteLine();

PrintMatrix(matrix);
Console.WriteLine();
ChangStringMatrix(matrix);
PrintMatrix(matrix);

/*

int[,] GetNewArray(int[,] matrix)
{       
  int[,] array = new int[matrix.GetLength(0), matrix.GetLength(1)];

  for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == 0)
            {
                array[i, j] = matrix[matrix.GetLength(0) - 1, j]; 
            }
            else if(i == matrix.GetLength(0) - 1)
            {
                array[i, j] = matrix[0, j];
            }
            else
            {
                array[i, j] = matrix[i, j];
            }
        }
    }
  return array;  
}
*/