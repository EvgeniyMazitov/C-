/*
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

        |
   2    |   1
--------------------->
    3   |   4
        |
*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while(true)
    {
        
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            if(result == 0)
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
            else
                break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

int GetQuarter(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    else if(x < 0 && y < 0)
        return 3;
    else if(x < 0 && y > 0)
        return 2;
    else
        return 4;
}


int x = GetNumber("Введите первое число:");
int y = GetNumber("Введите второе число:");
int quarter = GetQuarter(x, y);

Console.WriteLine($"Точка ({x}, {y}) лежит в {quarter} четверти");
