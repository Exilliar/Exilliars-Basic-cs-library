using System;

namespace ExBCSL
{
    public class BRead
    {
        /// <summary>
        /// Gets a string from the command line
        /// </summary>
        /// <param name="msg">The message to be displayed before the input</param>
        /// <returns></returns>
        public static string getString(string msg)
        {
            Console.Write(msg);

            return Console.ReadLine();
        }

        /// <summary>
        /// Gets an int from the command line
        /// </summary>
        /// <param name="msg">The message to be displayed before the input</param>
        /// <returns></returns>
        public static int getInt(string msg)
        {
            return Int32.Parse(getString(msg));
        }
    }
}
