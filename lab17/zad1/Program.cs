class Program
{
    static void Main(string[] args)
    {
        FileStream file = new FileStream(@"D:\!Практика c#\lab17\zad1\g.txt", FileMode.Open);
        StreamWriter w = new StreamWriter(file);
        Random r = new Random();
        int n = 10;
        int[] mas = new int[n];
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            w.WriteLine(r.Next(5, 25));
        }
        w.Close();
        FileStream file1 = new FileStream(@"D:\!Практика c#\lab17\zad1\g.txt", FileMode.Open);
        StreamReader reader1 = new StreamReader(file1);
        for (int i = 0; i < n; i++)
        {
            mas[i] = Convert.ToInt32(reader1.ReadLine());
            if (mas[i] % 2 == 0)
                sum++;
        }
        int razn = mas[0] - mas[mas.Length - 1];
        Console.WriteLine("Кол. четных чисел: " + sum);
    }
}
