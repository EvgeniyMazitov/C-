/*
Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да

*/

int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(-9, 10);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

bool FindElement(int[] arr, int digit)
{
    bool result = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == digit)
        {
            result = true;
        }

    }
    return result;
}

Console.WriteLine("Введите размерность массива:");
int dimension = int.Parse(Console.ReadLine());
int[] array = GetArray(dimension);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Введите число для поиска");
int digit = int.Parse(Console.ReadLine());
bool result1 = FindElement(array, digit);

if (result1 == true)
{
    Console.WriteLine("Число найдено в массиве");
}
else Console.WriteLine("Число не найдено в массиве");
