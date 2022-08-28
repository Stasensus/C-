// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] array = new double[3,4];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = (random.NextDouble() * 2 - 1) * 10;
        Console.Write("{0,6:F1}", array[i, j]);
    }
    System.Console.WriteLine();
}