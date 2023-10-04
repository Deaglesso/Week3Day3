namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Method(9,2));
        }
        public static int Method(int n)
        {
            return n * n;
        }
        public static int Method(int n, int m)
        {
            int res = 1;
            for (int i = 0; i < m; i++)
            {
                res *= n;
                
            }
            return res;
        }
    }
}