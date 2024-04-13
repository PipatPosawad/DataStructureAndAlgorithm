using Common.Array;

static int[] SelectionSort(int[] array)
{
    for (var i = 0; i < array.Length - 1; i++)
    {
        var minIndex = i;
        for (var j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minIndex])
                minIndex = j;
        }

        // swap
        var temp = array[minIndex];
        array[minIndex] = array[i];
        array[i] = temp;
    }
    return array;
}

var array = new int[] { 2, 11, 5, 10, 7, 8 };
array.PrintArray();
var result = SelectionSort(array);
result.PrintArray();

