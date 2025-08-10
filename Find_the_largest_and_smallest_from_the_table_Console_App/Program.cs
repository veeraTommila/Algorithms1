namespace Find_the_largest_and_smallest_from_the_table_Console_App
{
    /* What does this code do?
     * It creates a table with 10 random integers.
     * It finds the maximumValue and the minimumValue number.
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
            int maximumValue = numberTable[0];
            int minimumValue = numberTable[0];

            // Let us find the maximum and minimum value.
            for (int i = 1; i < numberTable.Length; i++)
            {
                if (numberTable[i] > maximumValue)
                    maximumValue = numberTable[i];
                if (numberTable[i] < minimumValue)
                    minimumValue = numberTable[i];
            }


            int difference = maximumValue - minimumValue;

            // Let us print the table and the results.
            Console.WriteLine("The numbers of the table: ");
            foreach (int number in numberTable) { 
                Console.WriteLine(number + " ");            
            }

            Console.WriteLine("\nThe maximum value: " + maximumValue);
            Console.WriteLine("The minimum value: " + minimumValue);
            Console.WriteLine("The differense: " + difference);
        }
    }
}
