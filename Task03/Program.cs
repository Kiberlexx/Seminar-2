void FillArray(int[] collection)
{
    int Lenght = collection.Length;
    int index = 0;
    while (index < Lenght)
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
        Console.WriteLine(col[position]);
        position++;
    }
}

int Array2(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;

        return position;
    }
}

int[] Array = new int[10];

FillArray(Array);
PrintArray(Array);
Console.WriteLine();
int pos = Array2(Array, 4);
Console.WriteLine(pos);

