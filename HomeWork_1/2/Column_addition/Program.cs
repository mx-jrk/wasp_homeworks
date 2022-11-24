class Program
{
    public static void Main(string[] args) {
        int a1 = Int32.Parse(Console.ReadLine()), a2 = Int32.Parse(Console.ReadLine()), a = a1+a2;
        string a1_s = "", a2_s = "", a_s = "";
        while (a1 != 0)
        {
            a1_s = (a1 & 1) + a1_s;
            a1 >>= 1;
        }
        while (a2 != 0)
        {
            a2_s = (a2 & 1) + a2_s;
            a2 >>= 1;
        }
        while (a != 0)
        {
            a_s = (a & 1) + a_s;
            a >>= 1;
        }
        while (a1_s.Length != a_s.Length) a1_s = '0' + a1_s;
        while (a2_s.Length != a_s.Length) a2_s = '0' + a2_s;
        Console.WriteLine(a1_s);
        Console.WriteLine(a2_s);
        Console.WriteLine();
        for (int i = 0; i < a1_s.Length; i++) Console.Write('.');
        Console.WriteLine();
        Console.WriteLine(a_s);

    }
}