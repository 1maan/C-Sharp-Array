using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("How Many elements: ");
        int elements = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[elements];
        for(int count = 0; count < array.Length; count++)
        {
            Console.Write("elements - {0} : ",count);
            array[count] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Elements in array are: ");

        for (int output = 0; output< array.Length; output++) {
            Console.Write(array[output] + " ");
        }


    }
}
//aeomv.com
