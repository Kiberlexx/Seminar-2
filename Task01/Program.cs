int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int[] Array = { 12, 42, 315, 34, 85, 6, 9, 80, 79 };
int sum = Max(Max(Array[0], Array[1], Array[2]), Max(Array[3], Array[4], Array[5]), Max(Array[6], Array[7], Array[8]));


Console.WriteLine(sum);
