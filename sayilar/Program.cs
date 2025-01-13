namespace sayilar
{
    internal class Program
    {
        public int Min(int[] numbers)
        {
            int min = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                { min = numbers[i]; }
            }
            return min;
        }
        public int Max(int[] numbers)
        {
            int max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                { max = numbers[i]; }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 54, 36, 25, 55, 88, 96, 32, 15, 17, 2, 100 };
            Program b = new Program();
            Console.WriteLine("Dizinin en küçük elemanı = {0}", b.Min(numbers));
            Console.WriteLine("Dizinin en büyük elemanı = {0}", b.Max(numbers));
            
            Console.ReadKey();


           

        }
     }
    }

