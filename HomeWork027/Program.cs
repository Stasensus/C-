// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number;
int sum = 0;
            while (count > 0)
            {
                sum = sum + count % 10;
                count = count / 10 ;
             }
 Console.WriteLine($"Сумма цифр в числе {number} = {sum}");
