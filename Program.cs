﻿
class Stack<T>
{
    List<T> list = new List<T>();
    public int Count => list.Count;

    public void Push(T el)
    {
        list.Insert(0, el);
    }

    public T Pop()
    {
        T temp = list.Last();
        list.RemoveAt(list.Count - 1);
        return temp;
    }

    public void Clear()
    {
        list.Clear();
    }

    public T Peek()
    {
        return list.Last();
    }

    public void CopyTo(ref T[] arr)
    {
        arr = list.ToArray();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Stack<int> a = new Stack<int>();
        a.Push(3);
        a.Push(4);
        a.Push(5);
        Console.WriteLine($"Peek: {a.Peek()}");
        Console.WriteLine($"Pop: {a.Pop()}");
        int[] b = new int[2];
        a.CopyTo(ref b);
        Console.Write("Array: ");
        foreach (var el in b)
        {
            Console.Write($"{el} ");
        }
        a.Clear();
        a.Push(1);
        a.CopyTo(ref b);
        Console.Write("\nArray after Clear(): ");
        foreach (var el in b)
        {
            Console.Write($"{el} ");
        }
    }
}
