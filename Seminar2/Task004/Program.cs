//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да


Console.WriteLine ("Введите первое число");
String FirstStr = Console.ReadLine();
int first = int.Parse(FirstStr);

if ((first % 7) == 0 && (first % 23) == 0)
{
    Console.WriteLine("Число кратное 7 и 23");
}
else
{
    Console.WriteLine($"Число не кратное");
}