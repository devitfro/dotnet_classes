namespace hw1;
class _2dArrays
{
    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter M: ");
        int M = int.Parse(Console.ReadLine());

        int num = 1;

        if (N <= 0 || N > 10 || M <= 0 || M > 10)
        {
            Console.WriteLine("Please enter a number between 1 and 10");
            N = int.Parse(Console.ReadLine());
            M = int.Parse(Console.ReadLine());
        }

        int[,] result = new int[N, M];

        for (int i = 0; i < M; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < N; j++)
                {
                    result[i, j] = num++;
                }
            }
            else
            {
                for (int j = N - 1; j >= 0; j--)
                {
                    result[i, j] = num++;
                }
            }
        }

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("{0, 4}", result[i, j]);
            }
            Console.WriteLine();
        }
    }
}
