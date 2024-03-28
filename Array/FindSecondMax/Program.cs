using Common.Array;

static int FindSecondMaximumValue(int[] array)
{
    int max = int.MinValue;
    int secondMax = int.MinValue;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            secondMax = max;
            max = array[i];
        }
        else if (array[i] > secondMax && array[i] != max)
        {
            secondMax = array[i];
        }
    }
    return secondMax;
}

var array = new int[] { 13, 34, 2, 34, 33, 1 };
array.PrintArray();
var result = FindSecondMaximumValue(array);
Console.WriteLine(result);