/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] GetArray(int dimension)
{
    double[] arr = new double[dimension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = (double)(randomizer.Next(0, 10000)) / 100;
    }

    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

double GetMaxElement(double[] arr)
{
    double max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }

    return max;
}

double GetMinElement(double[] arr)
{
    double min = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
    }

    return min;
}

Console.WriteLine("Введите размерность массива:");
int dimension = int.Parse(Console.ReadLine());

double[] array = GetArray(dimension);
PrintArray(array);

double max = GetMaxElement(array);
double min = GetMinElement(array);
double result = max - min;

Console.WriteLine();
Console.WriteLine($"Максимальный элемент массива = {max}");
Console.WriteLine($"Минимальный элемент массива = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением массива = {result}");