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
        string input = Console.ReadLine();
        String[] input_splitted = input.Split(':');
        int start = Int32.Parse(input_splitted[0]);
        int end = Int32.Parse(input_splitted[1]);
        int step = Int32.Parse(input_splitted[2]);
        //Console.WriteLine(start + " " + end + step);
        if (step > 0)
        {
            for (int i = start; i < end; i += step)
            {
                Console.Write(data[i] + " ");
            }
        }
        else
        {
            for (int i = end; i > start; i += step)
            {
                Console.Write(data[i] + " ");
            }
        }
    }
}