Console.WriteLine("Введите целое положительное пятизначное число");
string number = (Console.ReadLine());
string result = "XZ";
for (int i = 0, j = 4; j >= i; i++, j--)
{
    if (number[i] != number[j])
    {
       result = "False";
       break;
    }
    else result = "True";
}
System.Console.WriteLine(result);
