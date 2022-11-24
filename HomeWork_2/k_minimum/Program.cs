class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива");
        int N = Int32.Parse(Console.ReadLine());
        int[] data = new int[N];
        string data_input = Console.ReadLine();
        string[] data_input_splitted = data_input.Split(' ');
        for (int i = 0; i < N; i++)
        {
            data[i] = Int32.Parse(data_input_splitted[i]);
        }
        int k = Int32.Parse(Console.ReadLine());
        Array.Sort(data);
        Console.WriteLine(data[k - 1]);
    }
}
