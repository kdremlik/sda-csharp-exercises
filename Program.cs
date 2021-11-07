using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string unsorted = "89294729265";
            //int[] unsortedArray = new int[unsorted.Length];
            int[] unsortedArray = new int[10] {6, 43, 47, 65, 21, 234, 547, 44, 77, 88};
            BubbleSort(unsortedArray);
        }

        private static void BubbleSort(int[] unsortedArray)
        {
            //int[] sortedArray = new int[unsortedArray.Length];
            for (int i = 0; i < unsortedArray.Length -1; i+=2)
            {
                if (unsortedArray[i + 1] > unsortedArray[i]) 
                {
                    int tmp = unsortedArray[i+1];
                    unsortedArray[i+1] = unsortedArray[i];
                    unsortedArray[i] = tmp;
                }

                



            }

            foreach (int x in unsortedArray)
            {
                Console.WriteLine(x);
            }
        }
    }
}
//First Pass
//( 5 1 4 2 8 ) → (1 5 4 2 8 ), Here, algorithm compares the first two elements, and swaps since 5 > 1.
//( 1 5 4 2 8 ) → (1 4 5 2 8 ), Swap since 5 > 4
//( 1 4 5 2 8 ) → (1 4 2 5 8 ), Swap since 5 > 2
//( 1 4 2 5 8 ) → (1 4 2 5 8 ), Now, since these elements are already in order (8 > 5), algorithm does not swap them.
//Second Pass
//( 1 4 2 5 8 ) → (1 4 2 5 8 )
//(1 4 2 5 8 ) → (1 2 4 5 8 ), Swap since 4 > 2
//( 1 2 4 5 8 ) → (1 2 4 5 8 )
//(1 2 4 5 8 ) → (1 2 4 5 8 )
//Now, the array is already sorted, but the algorithm does not know if it is completed. The algorithm needs one additional whole pass without any swap to know it is sorted.

//Third Pass
//( 1 2 4 5 8 ) → (1 2 4 5 8 )
//(1 2 4 5 8 ) → (1 2 4 5 8 )
//(1 2 4 5 8 ) → (1 2 4 5 8 )
//(1 2 4 5 8 ) → (1 2 4 5 8 )
