using Common.Array;

static int[] ReverseArray(int[] array, int start, int end)
{
    while(start < end)
    {
        var temp = array[start];
        array[start] = array[end];
        array[end] = temp;
        start++;
        end--;
    }
    return array;
}

var array = new int[] { 2, 11, 5, 10, 7, 8 };
array.PrintArray();
var result = ReverseArray(array, 0, array.Length -1);
result.PrintArray();

