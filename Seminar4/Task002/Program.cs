/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5

*/

//метод, который возвращает число из консоли
// Метод возвращает число из консоли


string GetNumber(string message)
{
    int result = 0;
    string num = string.Empty;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while(true)
    {
        
        Console.WriteLine(message);
        num = Console.ReadLine();

        if(int.TryParse(num, out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return num;
}

string number = GetNumber("Введите число:");
Console.WriteLine($"Число {number} имеет {number.Length} знаков.");
