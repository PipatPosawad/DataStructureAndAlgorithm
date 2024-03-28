using Common.Array;

static int FindMinimumValue(int[] array)
{
    var min = array[0];
    for (var i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

var array = new int[] { 3, 2, 4, 7, 10, 6, 5 };
array.PrintArray();
var result = FindMinimumValue(array);
Console.WriteLine(result);