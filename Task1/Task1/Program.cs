namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 3 };
            int[] arr2 = { 1, 2, 3, 4, 5, 5 };
            Console.WriteLine(IsSorted(arr));
            Console.WriteLine(IsSorted(arr2));
        }
        public static bool IsSorted(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}