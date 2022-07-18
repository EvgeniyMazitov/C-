/*
Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

void FindElementInMatrix(int[,] matrix)
{
    List<int> result = new List<int>();
    result.Add(matrix[0, 0]);
    int buffer = 0;
    int count = 0;
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < result.Count; k++)
            {
                if (matrix[i, j] == result[k])
                {
                    buffer++;
                }
            }
            if (buffer == 0)
            {
                result.Add(matrix[i, j]);
            }
            buffer = 0;
        }
    }
    for (int k = 0; k < result.Count; k++)
    {
        count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == result[k])
                {
                    count++;
                }
            }
        }
        Console.WriteLine($"Элемент {result[k]} справочника встречается {count} раз");
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

FindElementInMatrix(matrix);


/*
Dictionary<int,int> GetDictionary(int[,] matrix)
{
    Dictionary<int,int> dic = new Dictionary<int, int>();

    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(dic.Keys.Contains(matrix[i,j]))
                dic[matrix[i,j]] = dic[matrix[i,j]] + 1;
            else
                dic.Add(matrix[i,j], 1);
        }
    }

    return dic;
}

int[,] matrix = InitMatrix(4,4);
PrintMatrix(matrix);
Dictionary<int,int> resultDic = GetDictionary(matrix);

foreach(var item in resultDic.OrderBy(x=>x.Key))
{
    Console.WriteLine($"элемент {item.Key} встречается {item.Value} раз");
}
using System.Linq;

*/