// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] array = new int[8];
Console.WriteLine("Введите массив из 8 цифр через пробел:");
string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
if (str.Length == 8) 
{
    int i;
    for (i = 0; i < 8; i++)
    {
        array[i] = Convert.ToInt32(str[i]);
    }
System.Console.WriteLine($"Результат: [{String.Join(";" ,array )}]");
}
else 
{
    System.Console.WriteLine("Неверная длина массива");
}