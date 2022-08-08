/*
Итоговая проверочная работа.

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Мы должны убедиться, что базовое знакомство с IT прошло успешно.

Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2,3 и 4 должны быть расположены в разных коммитах)

Задача:

Написать программу которая из имеющего массива строк формирует 
массив строк, длинна которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на страте выполнения алгоритма. 
При решении не рекомедуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

["Hello","2","world", ":-)"] -> ["2",":-)"]
["1234","1567","-2", "computer science"] -> ["-2"]
["Russia","Denmark","Kazan"] -> []
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

void GetStrings(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-ю строку:");
        stringArray[i] = Console.ReadLine();
    }
}

void PrintArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine(stringArray[i]);
    }
}

string[] FilterStringsArray(string[] stringArray)
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if ((stringArray[i]).Length > 3) count++;
    }
    string[] newArrayOfString = new string[stringArray.Length - count];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if ((stringArray[i]).Length <= 3)
        {
            newArrayOfString[j] = stringArray[i];
            j++;
        }
    }
    return newArrayOfString;
}

int m = GetNumber("Введите количество строк в массиве строк m:");

string[] arrayOfStrings = new string[m];
GetStrings(arrayOfStrings);
Console.WriteLine();
Console.WriteLine("Введенный массив:");
Console.WriteLine();
PrintArray(arrayOfStrings);
string[] newArrayOfStrings = FilterStringsArray(arrayOfStrings);
Console.WriteLine();
Console.WriteLine("Новый массив:");
Console.WriteLine();
PrintArray(newArrayOfStrings);