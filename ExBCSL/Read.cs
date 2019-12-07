using System;

namespace ExBCSL
{
    public class Read
    {
        public static string getString(string msg)
        {
            Console.Write(msg);

            return Console.ReadLine();
        }

        public static int getInt(string msg)
        {
            return Int32.Parse(getString(msg));
        }
    }
}
