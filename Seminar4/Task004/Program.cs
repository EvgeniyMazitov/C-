/*
Задача 30: Напишите программу, которая выводит массив
из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

/*
Можно заполнить массив и так:

Random rnd = new Random();
int [] array = new int [8];

for (int i = 0; i < 8; i++)
{
    array[i] = rnd.Next(0,2);
}
*/


void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(0, 2);
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

int [] array = new int [8];

FillArray(array);
PrintArray(array);