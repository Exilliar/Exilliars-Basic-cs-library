using System;
using ExBCSL;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            testArrays();
        }

        static void testRead()
        {
            int i = BRead.getInt("testing getting int: ");
            string s = BRead.getString("testing getting string: ");

            Console.WriteLine($"int: {i}");
            Console.WriteLine($"string: {s}");
        }

        static void testArrays()
        {
            int[] arr = new int[]{1,5,3,2,6,3,2};

            arr = BArrays.BSort.Bubble(arr);

            printArr(arr);
        }

        static void printArr(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i);
            }

            Console.WriteLine();
        }
    }
}
