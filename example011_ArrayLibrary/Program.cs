void FillArray(int[] collection)
{
    int n = collection.Length;
    int index = 0;
    while(index<n)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int Length = col.Length;
    int position = 0;
    while(position<Length)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int size = collection.Length;
    int index = 0;
    while(index<size)
    {
        if(collection[index]== find)
        {
            Console.WriteLine(index);
            break;
        }
        index++;
    }
    return index;
}

int[] array = new int [10];

FillArray(array);
PrintArray(array);

Console.WriteLine("");
IndexOf(array, 4);