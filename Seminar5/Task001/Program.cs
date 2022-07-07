/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
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

int GetPositiveSumm(int[] arr)
{
    int summ = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            summ += arr[i]; // summ = summ + arr[i];
    }

    return summ;
}

int GetNegativeSumm(int[] arr)
{
    int summ = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
            summ += arr[i];
    }

    return summ;
}

(int, int) GetPositiveAndNegativeSumm(int[] arr)
{
    int positiveSumm = 0;
    int negativeSumm = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            positiveSumm += arr[i];
        else
            negativeSumm += arr[i];
    }

    return (positiveSumm, negativeSumm);
}

Console.WriteLine("Введите размерность массива:");
int dimension = int.Parse(Console.ReadLine());

int[] array = GetArray(dimension);
PrintArray(array);

int positiveSumm = GetPositiveSumm(array);
int negativeSumm = GetNegativeSumm(array);

(int posSumm, int negSumm) = GetPositiveAndNegativeSumm(array);

Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел {positiveSumm}, отрицательных {negativeSumm}");
Console.WriteLine($"Через кортежи .Сумма положительных чисел {posSumm}, отрицательных {negSumm}");