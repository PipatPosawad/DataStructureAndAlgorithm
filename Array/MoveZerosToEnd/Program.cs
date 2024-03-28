using Common.Array;

static int[] MoveZerosToEnd(int[] array, int n)
{
    int zeroIndex = 0;
    for (int index = 0; index < n; index++)
    {
        if (array[index] != 0 && array[zeroIndex] == 0)
        {
            int temp = array[index];
            array[index] = array[zeroIndex];
            array[zeroIndex] = temp;
        }

        if (array[zeroIndex] != 0)
        {
            zeroIndex++;
        }
    }
    return array;
}

var array = new int[] { 8, 1, 0, 2, 1, 0, 3 };
array.PrintArray();
var result = MoveZerosToEnd(array, array.Length);
result.PrintArray();

