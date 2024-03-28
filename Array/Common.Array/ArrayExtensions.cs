namespace Common.Array;

public static class ArrayExtensions
{
    public static void PrintArray(this int[] array)
    {
        var n = array.Length;
        for(var i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
