/*
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

//метод, который возвращает число из консоли
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

//метод, который вычисляет сумму от 1 до переданного number
int GetSumm(int number)
{
    int result = 0;

    for(int i = 1; i <= number; i++)
        result += i;

    return result;
}

int number = GetNumber();
int result = GetSumm(number);

Console.WriteLine($"Сумма чисел от 1 до {number} = {result}");