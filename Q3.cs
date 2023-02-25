using System;

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
        Console.Write("Sum of all elements stored in the array is: ");
        int Sum = 0;
        for (int output = 0; output < array.Length; output++)
        {
            Sum = Sum + array[output];
        }
            Console.Write(Sum);
      

    }
}
//aeomv.com
