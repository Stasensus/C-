// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] array = new int[5,5];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(10);
        Console.Write(array[i, j] + "\t");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("Введите адрес строки:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите адрес столбца:");
int n = Convert.ToInt32(Console.ReadLine());

if (m <= array.GetLength(0) && n <= array.GetLength(1)) 
{
    System.Console.WriteLine($"По этому адресу находится элемент: {array[m,n]}");
}
else System.Console.WriteLine("Такого элемента нет");