// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[10];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,10);
}
for (int i = 1; i < array.Length; i+=2)
{
    sum += array[i];
}
System.Console.WriteLine($"[{String.Join("; ", array)}]");
System.Console.WriteLine($"Сумма элементов на нечетных позициях {sum}");