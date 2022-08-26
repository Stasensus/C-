System.Console.WriteLine("Сколько планируете ввести чисел?");
int quantityOfNumbers = Convert.ToInt32(Console.ReadLine());
int positiveNumbers = 0;
System.Console.WriteLine("Вводите, пожалуйста:");
for (int i = 0; i < quantityOfNumbers; i++)
{
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    if (inputNumber > 0) positiveNumbers++;
}
System.Console.WriteLine($"Количество введенных положительных чисел: {positiveNumbers}");