namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = IsOK();
            Console.WriteLine(SumofNumbers(n)); 
        }

        public static int IsOK()
        {
            int n = int.Parse(Console.ReadLine());
            
            if (n < 0)
            {
                 return IsOK();
            }
            else return n;
        }
        public static int SumofNumbers(int n)
        {
            int sum = 0;

            while (n != 0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }

            return sum;
        }

    }
}