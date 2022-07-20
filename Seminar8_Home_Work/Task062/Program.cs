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
int[,] InitMatrix(int m)
{
    int[,] matrix = new int[m, m];
    int decrement = 0;
    int angle = 1;
    int number = 1;
    int count = 0;
    int rule = 0;
    if (m % 2 == 1)
    {
        matrix[m / 2, m / 2] = m * m;
        rule++;
    }

    while (number <= m * m - rule)
    {
        if (angle == 1)
        {
            for (int j = 0 + decrement; j < m - 1 - decrement; j++)
            {
                matrix[0 + decrement, j] = number;
                number++;
            }
            angle = 2;
            count++;
        }

        else if (angle == 2)
        {
            for (int i = 0 + decrement; i < m - 1 - decrement; i++)
            {
                matrix[i, m - 1 - decrement] = number;
                number++;
            }
            angle = 3;
            count++;
        }

        else if (angle == 3)
        {
            for (int j = m - 1 - decrement; j >= 0 + 1 + decrement; j--)
            {
                matrix[m - 1 - decrement, j] = number;
                number++;
            }
            angle = 4;
            count++;
        }

        else if (angle == 4)
        {
            for (int i = m - 1 - decrement; i >= 0 + 1 + decrement; i--)
            {
                matrix[i, 0 + decrement] = number;
                number++;
            }
            angle = 1;
            count++;
        }

        if (count == 4)
        {
            count = 0;
            decrement++;
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

int m = GetNumber("Введите размерность матрицы m:");

int[,] matrix = InitMatrix(m);
Console.WriteLine();
Console.WriteLine($"Матрица размером {m}x{m}:");
Console.WriteLine();

PrintMatrix(matrix);