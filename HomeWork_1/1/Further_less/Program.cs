class Program
{
    public static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine()), lest_cor = 1, right_cor = n - 1;
        for (int i = 0; i < n; i++)
        {
            
            for (int j = 0; j < n; j++)
            {
                
                if (i == j)
                {
                    Console.Write(n + " ");
                    
                }
                else if (i > j)
                {
                    Console.Write((n - lest_cor) + " ");
                    lest_cor--;
                }
                else
                {
                    Console.Write((right_cor) + " ");
                    right_cor--;
                }
                
            }
            Console.WriteLine();
            lest_cor = i + 1;
            right_cor = n-1;
        }

    }
}