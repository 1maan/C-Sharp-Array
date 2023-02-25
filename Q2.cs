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
        Console.Write("The values store into the array are: ");

        for (int output = 0; output < array.Length; output++)
        {
            Console.Write(array[output] + " ");
        }
        Console.WriteLine();
        Console.Write("The values store into the array in reverse are: ");

        for (int outputrev = array.Length - 1; outputrev >= 0; outputrev--)
        {
            Console.Write(array[outputrev] + " ");
        }

    }
}
//aeomv.com
