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
            int[] arrBubble = new int[]{1,5,3,2,6,3,2};

            arrBubble = BArrays.BSort.Bubble(arrBubble);

            Console.WriteLine("bubble");
            printArr(arrBubble);

            int[] arrMerge = new int[]{1,5,3,2,6,3,2};

            arrMerge = BArrays.BSort.Merge(arrMerge);

            Console.WriteLine("Merge");
            printArr(arrMerge);
        }

        static void printArr(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
