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

            Console.WriteLine("Maximum element is : "+ arr.Max());
            Console.WriteLine("Minimum element is : " + arr.Min());


        }
    }
}
//aeomv.com
