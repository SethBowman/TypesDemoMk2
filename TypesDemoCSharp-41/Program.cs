namespace TypesDemoCSharp_41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Basic variables section

            //Variables

            //Number types

            //type - name - value
            int? whatever = null;
            //ints are whole numbers

            double average = 99.80;

            decimal cash = 500.00m;

            //Word types

            string myGreeting = "Hello, class!";

            char initial = 'B';

            //Fact type

            bool isAlive = true;


            //Value and Ref types section

            //Value types

            int a = 1;
            int b = a;

            a = 500;

            //Console.WriteLine(a);
            //Console.WriteLine(b);


            //Reference types 

            Point p1 = new Point();

            p1.X = 1;

            Point p2 = p1;

            p2.X = 500;

            Console.WriteLine(p1.X);
            Console.WriteLine(p2.X);

        }
    }
}