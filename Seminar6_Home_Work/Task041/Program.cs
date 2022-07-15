/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int arraylength = 0;

int GetCount(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число или не положительное число. Введите корректное число.";

    while (true)
    {

        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result)&&result>0)

            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

void FillArray(int[] collection)
{
    int index = 0;
    while (index < arraylength)
    {
        bool numberTest = false;
        int number = 0;
        while (numberTest == false)
        {
            Console.Write($"Введите {index + 1}-е число :");
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

int CountPositiv(int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0)
        result++;
    }
    return result;
}

arraylength = GetCount("Введите количество чисел (M) :");

int[] array = new int[arraylength];

FillArray(array);

int resultPositiv = CountPositiv(array);

Console.WriteLine($"Количество чисел > 0 = {resultPositiv}");