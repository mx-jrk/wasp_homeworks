class Program
{
    public static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        string answ = "";
        while (n != 0)
        {
            answ = (n & 1) + answ;
            n >>= 1;
        }
        Console.WriteLine(answ);
    }
}