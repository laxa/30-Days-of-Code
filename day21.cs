public static void printArray<T>(System.Collections.Generic.IEnumerable<T> array)
{
    foreach (T elem in array)
        Console.WriteLine(elem);
}
