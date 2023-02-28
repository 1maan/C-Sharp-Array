namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Input the number of elements to store in the first array : ");
        int array1length = Convert.ToInt32(Console.ReadLine());
        int[] array1 = new int[array1length];
        for(int arrayone = 0; arrayone < array1length; arrayone++)
            {
                Console.Write("element - {0} : ", arrayone);
                array1[arrayone] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Input the number of elements to store in the first array : ");
            int array2length = Convert.ToInt32(Console.ReadLine());
            int[] array2 = new int[array1length];
            for (int arraytwo = 0; arraytwo < array2length; arraytwo++)
            {
                Console.Write("element - {0} : ", arraytwo);
                 array2[arraytwo] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("The merged array in ascending order is :");

            for (int arraytwo = 0; arraytwo < array2length; arraytwo++)
            {
                Console.Write(array1[arraytwo]+" ");
                Console.Write(array2[arraytwo] + " ");
            }


        }
    }
}
//aeomv.com
