/*
Задача 67: Напишите программу, которая будет принимать
на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
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

void SumAllNumber(int number, int sum)
{
    if (number==0)
        Console.WriteLine(sum);
    else 
    {
        sum = sum+(number%10);
        SumAllNumber(number/10,sum);
    }
}

int m = GetNumber("Введите число M:");
int sum = 0;
SumAllNumber(m,sum);