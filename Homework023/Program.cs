System.Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    System.Console.WriteLine(Math.Pow(i+1, 3));
}