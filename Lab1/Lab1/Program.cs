using System;
using CustomCollections;
using CustomCollections.CustomEventArgs;

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

    public static void Main()
    {
        //Initializing array and subscribing on it`s events
        CustomArray<int> array = new CustomArray<int>();

        array.ItemAdded += PrintArrayItemEventArgs!;
        array.ItemRemoved += PrintArrayItemEventArgs!;
        array.ArrayCleared += (sender, e) => Console.WriteLine($"--> Event invoked: {e.Action} {e.ActionDateTime}");
        array.ArrayResized += (sender, e) =>
        Console.WriteLine($"--> Event invoked: {e.Action} {e.ActionDateTime} Old capacity: {e.OldCapacity} New capacity: {e.NewCapacity}");

        //Adding new items to array
        array.Insert(0, 2);
        array.Insert(1, 3);
        array.Insert(2, 5);
        array.Insert(2, 4);
        array.Insert(0, 1);

        Console.WriteLine("\nArray after adding elements:");
        array.Foreach(item => Console.Write(item + " "));

        //Removing items from array
        Console.WriteLine("\n");

        array.Remove(3);

        array.RemoveAt(2);

        Console.WriteLine("\nArray after removing several elements:");
        array.Foreach(item => Console.Write(item + " "));

        //Clearing array
        Console.WriteLine("\n");

        array.Clear();
        Console.WriteLine($"Count: {array.Count}");
    }

    public static void PrintArrayItemEventArgs(object sender, ArrayItemEventArgs<int> e)
    {
        Console.WriteLine($"--> Event invoked: {e.Action} {e.ActionDateTime} Item: {e.Item} Index: {e.Index}");
    }
}