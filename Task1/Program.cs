namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 2, 3, 4, 10 };

            (int odd, int even) = Task1(arr);

            Console.WriteLine($"odd: {odd} even: {even}");
        }


        public static (int odd, int even) Task1(int[] arr)
        {
            int odd = 0, even = 0;
            foreach(int _ in arr) {

                if (_ % 2 == 0) {

                    even += _;
                }
                else
                {
                    odd += _;
                }
                
            }

            return (odd, even);


        }
    }
}