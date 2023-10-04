namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 60,59,90 };
            if (AveragePoint(arr) > 60)
            {
                Console.WriteLine("mezun oldunuz");
            }
            else Console.WriteLine("mezun ola bilmediniz");
        }
        public static int AveragePoint(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (sum/arr.Length);
        }
    }
}