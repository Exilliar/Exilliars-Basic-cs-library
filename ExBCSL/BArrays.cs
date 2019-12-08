namespace ExBCSL
{
    public class BArrays
    {
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