using System;
using ExBCSL;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Read.getInt("testing getting int: ");
            string s = Read.getString("testing getting string: ");

            Console.WriteLine($"int: {i}");
            Console.WriteLine($"string: {s}");
        }
    }
}
