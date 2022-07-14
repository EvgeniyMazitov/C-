/*
Транспонирование матрицы
*/

int [,] InitMatrix(int m, int n)
{
    int [,] matrix = new int[m,n];
    Random randomizer = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = randomizer.Next(1,10);
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

int[,] TranspMatrix(int[,] mtrx, int m, int n)
{
    int[,] newMatrix = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            newMatrix[i,j] = mtrx[j,i];
        }
    }
    return newMatrix;
}
Console.WriteLine("Введите размер матрицы:");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,] matrix = InitMatrix(m, n);

Console.WriteLine($"Матрица размером {m}x{n}:");
PrintMatrix(matrix);
int[,] newMatrix = TranspMatrix(matrix,m,n);
Console.WriteLine($"Транспонированная (повернутая) матрица размером {n}x{m}:");
PrintMatrix(newMatrix);