namespace hw06._12 { 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter count of steps: ");

            string user_steps = Console.ReadLine();
            bool success = int.TryParse(user_steps, out int steps);

            if (!success || steps <= 0)
            {
                Console.WriteLine("Wrong, please enter correct number...");
                return;
            }

            int indentation = 3;
            for (int i = 0; i < steps; i++)
            {
                Console.WriteLine("***".PadLeft(indentation));
                Console.WriteLine("  *".PadLeft(indentation));
                indentation += 3;
            }
            Console.WriteLine("***".PadLeft(indentation));
        }
    }
}


