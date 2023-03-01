using System.Collections.Generic;
namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int n = int.Parse(Console.ReadLine());

            List<int> arr = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element - {i} : ");
                int add = int.Parse(Console.ReadLine());
                arr.Add(add);
            }
            arr.Sort();

                Console.Write("Elements of array in sorted ascending order: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");

                }
            Console.WriteLine();

            for (int i = 0; i < 1; i++)
            {
                Console.Write($"Element - {i} : ");
                int add = int.Parse(Console.ReadLine());
                arr.Add(add);
            }
            arr.Sort();
            Console.Write("Elements of array in sorted ascending order: ");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + " ");

            }
        }
    }
}
//aeomv.com
