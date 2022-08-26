System.Console.WriteLine("Сколько планируете ввести чисел?");
int x = Convert.ToInt32(Console.ReadLine());
int count = 0;
System.Console.WriteLine("Вводите, пожалуйста:");
for (int i = 0; i < x; i++)
{
    int y = Convert.ToInt32(Console.ReadLine());
    if (y > 0) count++;
}
System.Console.WriteLine($"Количество введенных положительных чисел: {count}");