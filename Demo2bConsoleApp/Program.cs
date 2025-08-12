namespace Demo2bConsoleApp
{
    /* What does this code do?
     * The code removes duplicates from a sorted array by replacing them with zero and counts how many numbers were zeroed. 
     * It initializes an array.
     * It goes trhough the array with a loop.?
     * It prints the array and the number of zeroed numbers.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbertable = { 1, 2, 3, 3, 4, 4, 5, 6, 7, 7, 8, 9, 10 }; // Initializing the table.           
            int numberOfZeros = 0;  // Initializing the counter.

            // Let's go through the table with a single loop.
            for (int i = 1; i < numbertable.Length; i++)
            {

                if (numbertable[i] == numbertable[i - 1])
                {
                    numbertable[i] = 0;
                    numberOfZeros++;
                }
            }

            // Printing the modified table.
            Console.WriteLine("Modified table:");
            foreach (int number in numbertable)
            {
                Console.WriteLine(number + " ");
            }

            // The number of reset entries is being printed.
            Console.WriteLine("\nNumber of zeroed numbers: " + numberOfZeros);
        }
    }
}
