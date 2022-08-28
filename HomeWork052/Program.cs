// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

double[,] matrix = new double[5,5];
Random random = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = Math.Round((random.NextDouble() * 9), 0);
        Console.Write("{0,5:F0}", matrix[i, j]);
    }
    System.Console.WriteLine();
}

double sum = 0;
double average = 0;
double [] array = new double[5];
for (int j = 0; j < matrix.GetLength(1); j++)
{
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = sum + matrix[i,j];
    }
    average = sum / matrix.GetLength(0);
    array[j] = average;
    sum = sum - sum;
    average = average - average;
}
System.Console.WriteLine($"[{String.Join("; ", array)}]");
