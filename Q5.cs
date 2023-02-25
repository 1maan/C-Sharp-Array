using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input the number of elements to store in the array : ");
        int elements = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[elements];
        for (int count = 0; count < array.Length; count++)
        {
            Console.Write("elements - {0} : ", count);
            array[count] = Convert.ToInt32(Console.ReadLine());
        }
        Dictionary<int, int> counts = new Dictionary<int, int>();
        for (int i = 0; i < array.Length; i++)
        {
            if (!counts.ContainsKey(array[i]))
            {
                counts.Add(array[i], 1);
            }
            else
            {
                counts[array[i]]++;
            }
        }
        foreach (KeyValuePair<int, int> pair in counts)
        {
            if (pair.Value > 1)
            {
                Console.WriteLine(pair.Key + " " + pair.Value + " check");
            }
        }
        Console.WriteLine(counts.Count(pair => pair.Value > 1) + " doubleCount");
    }
}
