﻿// int[] array = new int [10];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 3000);
//     Console.Write(array[i] + " ");
// }




// System.Console.Write("Введите количество элементов массива:");
// int elementsCount = int.Parse(Console.ReadLine());
// int [] array = new int[elementsCount];
// for (int i = 0; i < array.Length; i++)
// {
//     System.Console.Write($"Введите элемент массива №{i}: ");
//     array[i] = int.Parse(Console.ReadLine());
// }
// System.Console.WriteLine($"У вас получился массив [{String.Join("; ", array)}]");

string[] array = new string[5];
string str;
int count = 0;
int j = 0;
Console.WriteLine("Введите строки: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToString(Console.ReadLine());
    str = array[i];
    if (str.Length <= 3)
        {
           count++;
        }
}
string[] array2 = new string[count];
for (int i = 0; i < array.Length; i++)
{
    str = array[i];
    if (str.Length <= 3)
    {
        array2[j] = array[i];
        j++;
    }
}
// array = array.Where(x => x != null).ToArray();
if (array2.Length == 0) System.Console.WriteLine("Массив не содержит элементов короче 4 символов");
else System.Console.WriteLine($"Элементы массива, содержащие не более трёх символов: [{String.Join(", ", array2)}]");


// string[] array2 = new string[5];
// for (int i = 0; i < array2.Length; i++)
// {
//     if 
// }