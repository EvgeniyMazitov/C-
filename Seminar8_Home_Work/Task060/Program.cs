/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
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


int[,,] InitMatrix(int m, int n, int l)
{
    int[,,] massiv = new int[m, n, l];
    Random randomizer = new Random();
    List<int> unique = new List<int>();
    int tryUnique = 0;
    int testCount = 0;
    bool testUnique = false;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                while (testUnique != true)
                {
                    tryUnique = randomizer.Next(10, 100);
                    for (int o = 0; o < unique.Count; o++)
                    {
                        if (tryUnique == unique[o])
                        {
                            testCount++;
                        }
                    }
                    if (testCount == 0)
                    {
                        massiv[i, j, k] = tryUnique;
                        unique.Add(tryUnique);
                        testUnique = true;
                    }
                    else
                        testCount = 0;
                }
                testUnique = false;
            }
        }
    }
    return massiv;
}

void PrintMatrix(int[,,] massiv, int m, int n, int l)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int k = 0; k < massiv.GetLength(2); k++)
            {
                Console.Write($"{massiv[i, j, k]}({i},{j},{k})  ");
            }
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Введите 1-ю размерность массива m:");
int n = GetNumber("Введите 2-ю размерность массива n:");
int l = GetNumber("Введите 3-ю размерность массива l:");

int[,,] massiv = InitMatrix(m, n, l);
Console.WriteLine();
Console.WriteLine($"Массив размером {m}x{n}x{l}:");
Console.WriteLine();
PrintMatrix(massiv, m, n, l);