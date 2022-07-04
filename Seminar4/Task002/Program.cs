/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
/*
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

*/

//Второй способ решения

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

int i = 0;
int number = GetNumber("Введите число");
int number1 = number;
while(number1>1)
        {
            number1 = number1/10;
            i++;
        }
Console.WriteLine($"Колличество цифр в числе {number} {i}");
