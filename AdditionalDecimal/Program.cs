System.Console.WriteLine("Введите десятичное число:");
int decimalNumber = Convert.ToInt32(Console.ReadLine());
int temp = 0;
int count = 0;
int tempDecimalNumer = 0;
int tempDecimalNumber = decimalNumber;
for (int i = 0; tempDecimalNumber > 0; i++)
{
    tempDecimalNumber = tempDecimalNumber / 2;
    count++;
}
int [] array = new int [count];
for (int i = 0; i < count; i++)
{
    temp = decimalNumber % 2;
    decimalNumber = decimalNumber / 2;
    array[i] = temp;
}

System.Console.WriteLine("Запись в двоичном коде:");

int [] result  = new int [count];
int lastIndex = count - 1;
for (int i = 0; i < count; i++)
{
    result[i] = array[lastIndex - i];
    System.Console.Write(result[i] + "\t");
}
