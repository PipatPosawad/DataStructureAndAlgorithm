using Common.Array;

static int[] InsertionSort(int[] array)
{
    for (var i = 1; i < array.Length; i++)
    {
        var j = i;
        while (j >= 1 && array[j - 1] > array[j])
        {
            var temp = array[j-1];
            array[j-1] = array[j];
            array[j] = temp;

            j--;
        }
    }
    return array;
}

var array = new int[] { 2, 11, 5, 10, 7, 8 };
array.PrintArray();
var result = InsertionSort(array);
result.PrintArray();

