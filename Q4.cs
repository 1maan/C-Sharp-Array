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
        int[] array2 = new int[array.Length];
        Console.Write("The elements stored in the first array are: ");
        for (int output = 0; output < array.Length; output++)
        {
            array2[output] = array[output];
            Console.Write(array[output] + " ");
        }
        Console.WriteLine();
        Console.Write("The elements copied into the second array are: ");
        for (int output = 0; output < array2.Length; output++)
        {
            Console.Write(array2[output]+" ");
        }


    }
}
//aeomv.com
