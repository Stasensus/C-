Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) 
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    string number2 = Convert.ToString(number);
    System.Console.WriteLine($"Третья цифра - {number2[2]}");
}
