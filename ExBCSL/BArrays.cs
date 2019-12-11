using System;

namespace ExBCSL
{
    public class BArrays
    {
        /// <summary>
        /// Fills one array with another, up to a set limit. Takes an input of an array in order to get size. Arrays must be strings. NEEDS TEST
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

        public class BSort
        {
            /// <summary>
            /// Runs a basic bubble sort. Orders from highest to lowest. NEEDS TEST
            /// </summary>
            /// <param name="a">Array to be sorted</param>
            /// <returns>Sorted array</returns>
            public static int[] Bubble(int[] a)
            {
                int placeholder;

                for (int i = 0; i < a.Length; i++)
                {
                    for (int x=i; x < a.Length; x++)
                    {
                        if (a[i] < a[x])
                        {
                            placeholder = a[i];
                            a[i] = a[x];
                            a[x] = placeholder;
                        }
                    }
                }

                return a;
            }

            /// <summary>
            /// A basic merge sort NEEDS TESTING
            /// </summary>
            /// <param name="array">The array to be sorted</param>
            /// <returns>A sorted array</returns>
            public static int[] Merge(int[] array) // An abstraction of the merge sort, only here so that the user does not have to manually input the middle index of the array
            {
                int middle = (int)Math.Floor((double)array.Length/2);

                return MergeRecursive(array,middle);
            }

            /// <summary>
            /// The actual merge sort
            /// </summary>
            /// <param name="arr">The array to be sorted</param>
            /// <param name="middle">The middle index of the array</param>
            /// <returns></returns>
            private static int[] MergeRecursive(int[] arr, int middle)
            {
                int[] arr1 = new int[middle];
                int[] arr2 = new int[arr.Length-middle];

                arr1 = MergeFillArr(arr,0,middle);
                arr2 = MergeFillArr(arr,middle,arr.Length-middle);

                int arr1Mid = (int)Math.Floor((double)arr1.Length/2);
                int arr2Mid = (int)Math.Floor((double)arr2.Length/2);

                if (arr1.Length <= 0 || arr2.Length <= 0)
                {
                    Console.WriteLine("error, exiting to prevent infinate loop");
                    return new int[0]; // Add in throwing error here
                }

                if (arr1.Length == 1 && arr2.Length == 1) return CombineArr(arr1, arr2);
                else if (arr1.Length != 1 && arr2.Length == 1) return CombineArr(MergeRecursive(arr1,arr1Mid),arr2);
                else if (arr1.Length == 1 && arr2.Length != 1) return CombineArr(arr1,MergeRecursive(arr2,arr2Mid));
                else return CombineArr(MergeRecursive(arr1,arr1Mid), MergeRecursive(arr2,arr2Mid));
            }

            /// <summary>
            /// A special fill array exclusively for the merge sort
            /// </summary>
            /// <param name="arr"></param>
            /// <param name="start"></param>
            /// <param name="size"></param>
            /// <returns></returns>
            private static int[] MergeFillArr(int[] arr, int start, int size)// fills an array with values from another array up to a selected index
            {
                int[] a = new int[size];

                for (int i = start; i < size+start; i++)
                {
                    a[i-start] = arr[i];
                }

                return a;
            }

            /// <summary>
            /// Combines two arrays. NEEDS TEST
            /// </summary>
            /// <param name="arr0"></param>
            /// <param name="arr1"></param>
            /// <returns></returns>
            private static int[] CombineArr(int[] arr0, int[] arr1)
            {
                int[] a = new int[arr0.Length+arr1.Length];

                int arr0Pos = 0;
                int arr1Pos = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (arr0Pos < arr0.Length && arr1Pos < arr1.Length)
                    {
                        if (arr0[arr0Pos] <= arr1[arr1Pos])
                        {
                            a[i] = arr0[arr0Pos];
                            arr0Pos ++;
                        }
                        else
                        {
                            a[i] = arr1[arr1Pos];
                            arr1Pos ++;
                        }
                    }
                    else
                    {
                        if (arr0Pos < arr0.Length)
                        {
                            a[i] = arr0[arr0Pos];
                            arr0Pos ++;
                        }
                        else
                        {
                            a[i] = arr1[arr1Pos];
                            arr1Pos ++;
                        }
                    }
                }

                return a;
            }
        }
    }
}