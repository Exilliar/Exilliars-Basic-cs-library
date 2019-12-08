namespace ExBCSL
{
    public class BArrays
    {
        /// <summary>
        /// Fills one array with another, up to a set limit. Takes an input of an array in order to get size. Arrays must be strings
        /// </summary>
        /// <param name="a0">The array to be filled</param>
        /// <param name="a1">The array with the data</param>
        /// <param name="limit">How far to fill the array up to</param>
        /// <returns>A filled array of type string</returns>
        public static string[] FillArr(string[] a0, string[] a1, int limit)
        {
            for (int i = 0; i < limit; i++)
            {
                a0[i] = a1[i];
            }

            return a0;
        }
    }
}