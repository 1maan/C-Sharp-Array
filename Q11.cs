namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element - {i} : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.Write("Elements of array in sorted ascending order: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
  
            }


        }
    }
}
//aeomv.com
