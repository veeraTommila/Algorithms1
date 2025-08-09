namespace EvenlyDivisibleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Anna luku:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna luku:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Minkä tulon haluat?");
            int c = Convert.ToInt32(Console.ReadLine()); ;
            //int jakojaannos = a % b;
            //while (jaettava >= jakaja)
            //{
            //    jaettava = jaettava - jakaja;
            //}
            if (b * a == c || a * b == c)
                Console.WriteLine("Luvut " + a + " ja " + b + " voidaan kertoa keskenään luvulle " + c);
            else
                Console.WriteLine("Lukuja " + a + " ja " + b + " ei voida kertoa keskenään luvulle " + c);
        }
    }
}
