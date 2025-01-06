namespace hw06._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter count of step: ");
            int count_step = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your enter - " + count_step);

            for (int i = 0; i < count_step; i++)
            {
                for (int j = 0; j < i * 2; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("***");

                for (int j = 0; j < (i + 1) * 2; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("*");
            }
        }
    }
}

