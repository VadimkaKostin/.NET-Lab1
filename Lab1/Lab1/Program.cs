using System;
using CustomCollections;

namespace Lab1;

public static class Program
{
    public static void Foreach<T>(this IEnumerable<T> enumerable, Action<T> action)
    {
        foreach (var item in enumerable)
        {
            action(item);
        }
    }

    public static void Main(string[] args)
    {
        CustomArray<int> array = new CustomArray<int>(16) { 1, 2, 3, 4, 5 };

        array.Insert(2, 6);

        array.Foreach(x => Console.Write(x + " "));

        Console.WriteLine();

        array.RemoveAt(-1);

        array.Foreach(x => Console.Write(x + " "));
    }
}