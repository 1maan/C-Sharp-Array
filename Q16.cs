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
            int max = int.MinValue;
            int secondMax = int.MinValue;
            foreach (int num in arr)
            {
                if (num > max)
                {
                    secondMax = max;
                    max = num;
                }
                else if (num > secondMax && num < max)
                {
                    secondMax = num;
                }
            }
            Console.WriteLine("The second largest element in the list is: " + secondMax);
        }
    }
}
//aeomv.com
