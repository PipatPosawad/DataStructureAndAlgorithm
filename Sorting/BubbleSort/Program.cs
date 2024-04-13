using Common.Array;

static int[] BubbleSort(int[] array)
{
    for (var i = 0; i < array.Length - i; i++)
    {
        var j = i;
        while (j + 1 < array.Length)
        {
            if (array[j] > array[j + 1])
            {
                var temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
            j++;
        }
    }
    return array;
}

var array = new int[] { 2, 11, 5, 10, 7, 8 };
array.PrintArray();
var result = BubbleSort(array);
result.PrintArray();

