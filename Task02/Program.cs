int[] array = { 15, 23, 3, 24, 5, 66, 76, 82, 66 };
int n = array.Length;
int find = 66;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

