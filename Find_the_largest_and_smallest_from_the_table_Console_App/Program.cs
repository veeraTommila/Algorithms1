namespace Find_the_largest_and_smallest_from_the_table_Console_App
{
    /* What does this code do?
     * It creates a table with 10 random integers.
     * It finds the largest and the smallest number.
     * It calculates their difference.
     * It prints everything clearly.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numberTable = new int[10];

            // Let us fill the array / table with random numbers (for example with numbers between 1-100).
            for (int i = 0; i < numberTable.Length; i++)
            {
                numberTable[i] = random.Next(1, 101);
            }

            // Let us initialize the maximum and minimum with the first value.
            int largest = numberTable[0];
            int smallest = numberTable[0];

            // Let us find the largest and smallest value.
            for (int i = 1; i < numberTable.Length; i++)
            {
                if (numberTable[i] > largest)
                    largest = numberTable[i];
                if (numberTable[i] < smallest)
                    smallest = numberTable[i];
            }


            int difference = largest - smallest;

            // Let us print the table and the results.
            Console.WriteLine("The numbers of the table: ");
            foreach (int number in numberTable) { 
                Console.WriteLine(number + " ");            
            }

            Console.WriteLine("\nThe largest: " + largest);
            Console.WriteLine("The smallest: " + smallest);
            Console.WriteLine("The differense: " + difference);
        }
    }
}
