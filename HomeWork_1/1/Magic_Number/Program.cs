class Program
{
    public static void Main(string[] args)
    {
        for (int i = 1; i < 10; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                for (int k = j + 1; k < 10; k++)
                {
                    for (int z = k + 1; z < 10; z++)
                    {
                        Console.Write(i);
                        Console.Write(j);
                        Console.Write(k);
                        Console.WriteLine(z);
                    }
                }
            }
        }
    }
}
