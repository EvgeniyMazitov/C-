/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10

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

string DecimalToBinar( int number)
{
int result = 0;
string buffer = string.Empty;
while (number >0)
{
    result = number%2;
    number=number/2;
    buffer=buffer + result;
//    Console.Write(result);
}
return buffer;
}

void ReverseString(string inputString)
{for (int i = inputString.Length-1; i >=0; i--)
{
   Console.Write(inputString[i]); 
}

}

int number1 = GetNumber("Введите число");
string resultString = DecimalToBinar(number1);
ReverseString(resultString);
