/* Author: AnnaBella DeChick 
 * Date: 2/7/2023
 * Assignment: C# console application that computes the first 25 numbers of the Fibonacci sequence
*/

namespace deliverable_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] fibonacci = new int[25];

            // Initialize fibonacci series
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 0; i < fibonacci.Length; i++)
            {

                if (i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }

                Console.WriteLine("Fibonacci(" + i + ") = " + fibonacci[i]);
            }
        }
    }
}
