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


// Метод заполняет и распечатывает массив с числами от 1 до 99
int[] FillArray(int count)
{
    int[] array = new int[count];
    Random rnd = new Random();

    for (int i = 0; i < count; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
    return array;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write($"{item} ");
    }
}

int[]  CopyArray(int[] array)
{
    int [] resultArray = new int[array.Length];
    
    for (int i = 0; i < array.Length; i++)
    {
        resultArray[i] = array[i];
    }

    return resultArray;
}


int number = GetNumber("Введите количество элементов массива: ");
int[] firstArray = FillArray(number);
PrintArray(firstArray);
Console.WriteLine();
PrintArray(CopyArray(firstArray));