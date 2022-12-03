int[] array= {1,34,56,7,86,46,8,564,5,55,7756,7,4,4,5,555,4,4,55,4};
int n = array.Length;
int find = 4;
int index = 0;

while(index< n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
