/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.WriteLine(message);

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

void Fibonacci(int number)
{
    int newDigit = 1;
    int oldDigit = 0;
    int result = 0;
    Console.Write($"{oldDigit} ");
    Console.Write($"{newDigit} ");
    for (int i = 0; i < number - 2; i++)
    {
        result = oldDigit + newDigit;
        oldDigit = newDigit;
        newDigit = result;
        Console.Write($"{newDigit} ");
    }
}

int number1 = GetNumber("Введите число");
Fibonacci(number1);

/*

int GetNumber()
{
    int result = 0;
    Console.WriteLine("Введите число:");
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Введите корректное число");
        }
    }

    return result;
}


void Fibonacci(int number)
{
    int result = 0;
    int sum = 0;
    int firstnumber = 1;
    int secondnumber = 1;

    if (number == 0)
    {
        Console.WriteLine("0");
        return;
    }
    else if(number == 1)
    {
Console.Write("0 1 1 ");
    for (int i = 3; i < number; i++)
    {   
        sum = firstnumber + secondnumber;
        firstnumber = secondnumber;
        secondnumber = sum;
        Console.Write($"{sum} ");
    }
    
}
int number1 = GetNumber();
Fibonacci(number1);

*/