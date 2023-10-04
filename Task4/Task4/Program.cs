namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area(5);
            Area(5,4);
            Area(5,3,2);
            Area(3,4,5,2);
        }
        public static void Area(int r)
        {
            Console.WriteLine(3 * (r * r));
        }
        public static void Area(int a,int b)
        {
            Console.WriteLine(a*b);
        }
        public static void Area(int a,int b,int c)
        {
            Console.WriteLine(2 * ((a * b) + (a * c) + (b * c)));
        }
        public static void Area(int a,int b,int c, int r)
        {
            int p = (a + b + c) / 2;
            Console.WriteLine(p * r);
        }
    }
}