// int[] array = {1, 2, 3, 4, 5, 6, 7, 8};
// int n = array.Length;
// int find = 7;
// int index = 0;

// while (index < n)
// {
//     if(array[index] == find)
//     {
//         System.Console.WriteLine(index);
//     }
//     index++;
// }

void FillArray(int[] collection)
{
    int lentgh = collection.Length;
    int index = 0;
    while (index < lentgh)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] Array = new int[10];

FillArray(Array);
PrintArray(Array);
System.Console.WriteLine();

int pos = IndexOf(Array, 44);
System.Console.WriteLine(pos);
