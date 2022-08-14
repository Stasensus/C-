Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number / 10 % 10;
System.Console.WriteLine($"Вторая цифра: {result}");

