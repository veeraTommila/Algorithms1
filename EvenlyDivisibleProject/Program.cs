namespace EvenlyDivisibleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What output do you want?");
            int c = Convert.ToInt32(Console.ReadLine()); ;
            //int quotient = a % b;
            //while (dividend >= divisor)
            //{
            // divisor = divisor - divisor;
            //}
            if (b * a == c || a * b == c)
                Console.WriteLine("The numbers " + a + " and " + b + " can be multiplied together to get " + c);
            else
                Console.WriteLine("The numbers " + a + " and " + b + " cannot be multiplied together to get " + c);
        }
    }
}
