// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double [] array = new double[10];
double min = 100;
double max = 0;
for (int i = 0; i < array.Length; i++)
{
    double minRange = 1;
    double maxRange = 100;
    Random rand = new Random ();
    double number = Math.Round((rand.NextDouble()*(maxRange - minRange) + minRange), 2);
    array[i] = number;
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) 
    {
        min = array[i];
    }
    if (array[i] > max) 
    {
        max = array[i];
    }
}
System.Console.WriteLine($"[{String.Join("; ", array)}]");
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива составляет {Math.Round((max - min), 2)}");