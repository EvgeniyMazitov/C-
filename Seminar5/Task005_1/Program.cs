/* Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве. 
[1 2 3 4 5] -> 5 8 3*/ 
 
int[] GetArray(int dimension) 
{ 
 int[] arr = new int[dimension]; 
 Random randomizer = new Random(); 
 
 for (int i = 0; i < arr.Length; i++) 
 { 
 arr[i] = randomizer.Next(1, 10); 
 } 
 
 return arr; 
} 
 
void PrintArray(int[] arr) 
{ 
 for (int i = 0; i < arr.Length; i++) 
 { 
 Console.Write($"{arr[i]} "); 
 } 
} 
 
void Multipl(int[] arr) 
{ 
 string result = string.Empty; 
 for (int i = 0; i < arr.Length/2; i++) 
 { 
 int res = arr[i] * arr[arr.Length - 1 - i]; 
 result += $"{res} "; 
 } 
 if (arr.Length % 2 == 0) 
 Console.WriteLine(result); 
 else 
 { 
 Console.WriteLine(result + $" {arr[arr.Length/2]}"); 
 
 } 
 
} 
 
Console.WriteLine("Введите число элементов: "); 
int multiple = int.Parse(Console.ReadLine()); 
 
int[] array = GetArray(multiple); 
PrintArray(array); 
Console.WriteLine(); 
Multipl(array);