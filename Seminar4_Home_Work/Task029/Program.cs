/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов
и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int length = 8;

void FillArray(int[] collection)
{
    int index = 0;
    while (index < length)
    {
        bool numberTest = false;
        int number = 0;
        while (numberTest == false)
        {
            Console.Write($"Введите {index + 1}-й элемент массива :");
            string numberUser = Console.ReadLine();
            numberTest = int.TryParse(numberUser, out number);
            if (numberTest == false)
            {
                Console.WriteLine("Вы ввели не число");
            }
        }
        collection[index] = number;
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] array = new int[length];

Console.WriteLine($"Требуется ввести {length} элементов массива");

FillArray(array);
PrintArray(array);