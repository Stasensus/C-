// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] matrix = new int[5,5];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(10);
        Console.Write(matrix[i, j] + "\t");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine("Введите адрес строки:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите адрес столбца:");
int n = Convert.ToInt32(Console.ReadLine());

if (m <= matrix.GetLength(0) && n <= matrix.GetLength(1)) 
{
    System.Console.WriteLine($"По этому адресу находится элемент: {matrix[m,n]}");
}
else System.Console.WriteLine("Такого элемента нет");