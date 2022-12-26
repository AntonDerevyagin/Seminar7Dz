// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 1 7 -> такого числа в массиве нет 

Console.Write("Введите строку: "); 
int posel1 = Convert.ToInt32(Console.ReadLine()) - 1; 
Console.Write("Введите столбец: "); 
int posel2 = Convert.ToInt32(Console.ReadLine()) - 1; 
int n = 3; 
int m = 4; 
Random random = new Random(); 
int[,] arr = new int[n, m]; 
Console.WriteLine("Исходный массив: "); 
for (int i = 0; i < arr.GetLength(0); i++) 
{ 
    for (int j = 0; j < arr.GetLength(1); j++) 
{ 
    arr[i, j] = random.Next(10, 99); 
    Console.Write("{0} ", arr[i, j]); 
} 
Console.WriteLine(); 
} 
if (posel1 < 0 | posel1 > arr.GetLength(0) - 1 | posel2 < 0 | posel2 > arr.GetLength(1) - 1) 
{ 
    Console.WriteLine("Элемента в массиве нету"); 
} 
else 
{ 
    Console.WriteLine("Значение элемента массива = {0}", arr[posel1, posel2]); 
}