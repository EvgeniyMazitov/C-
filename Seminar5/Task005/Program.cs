/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21

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



void VivodMulti(int[] arr)
{
    int result = 0;
    int middle = 0;
    int halfLength = (arr.Length - 1) / 2;
    if (arr.Length % 2 == 0)
    {
        for (int i = 0; i <= halfLength; i++)
        {
            result = arr[i] * arr[arr.Length - 1 - i];
            Console.Write($"{result} ");
        }
    }
    else
       {
        for (int i = 0; i <= halfLength-1; i++)
        {
            result = arr[i] * arr[arr.Length - 1 - i];
            Console.Write($"{result} ");
        }

        {
            middle = ((arr.Length - 1) / 2);
            Console.Write(arr[middle]);
        }
    }
}

Console.WriteLine("Введите размерность массива:");
int dimension = int.Parse(Console.ReadLine());

int[] array = GetArray(dimension);

PrintArray(array);
Console.WriteLine();

VivodMulti(array);
Console.WriteLine();