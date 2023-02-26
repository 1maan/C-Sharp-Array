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
        int we = 3;
        for (int count = 0; count < array.Length; count++)

            for (int count2= count; count2 < array.Length; count2++)
            {
                if(we == 3) { 
                if(array[0] != array[1] && array[0] != array[2])
                    {
                        Console.WriteLine("The unique elements found in the array are :" + array[count2]);
                        we = 4;
                        break;
                    }
                if (array[count] != array[count2])
                {          
                    Console.WriteLine("The unique elements found in the array are :"+ array[count2]);
                        we = 4;
                        break;
                }
            }
        }
    }
}

