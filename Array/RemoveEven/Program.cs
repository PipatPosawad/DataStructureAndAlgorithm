using Common.Array;

static int[] RemoveEven(int[] array)
{
    var oddCount = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            oddCount++;
        }
    }
    var result = new int[oddCount];
    var index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            result[index] = array[i];
            index++;
        }
    }
    return result;
}

var array = new int[] { 3, 2, 4, 7, 10, 6, 5 };
array.PrintArray();
var result = RemoveEven(array);
result.PrintArray();