// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int fact = 1;
int current = 1;
while (current < number)
{
    current++;
    fact = fact * current;
}
System.Console.WriteLine("Факториал " + number + " - " + fact);