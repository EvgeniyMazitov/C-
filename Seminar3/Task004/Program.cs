/*
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число.");
        }
    }

    return result;
}

void Sqrt(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine(Math.Pow(i, 2));
    }
}

int number = GetNumber("Введите число");

Sqrt(number);