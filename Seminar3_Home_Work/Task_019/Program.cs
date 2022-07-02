/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не пятизначное число. Введите корректное число.";

    while (true)
    {

        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            if (result >= 10000 && result <= 99999)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

void Palindrom(int number)
{
    if(number/10000 == number%10 && (number%10000 - number%1000)/1000== (number%100 - number%10)/10)
        Console.WriteLine("число является палиндромом");
    else
        Console.WriteLine("число не является палиндромом");

}

int number = GetNumber("Введите пятизначное число : ");

Palindrom(number);