using System.Diagnostics;

class Program
{
    static void Sum()
    {
        int sum = 0;
        for (int i = 1; i < 11; i++)
        {
            sum += i;
        }
        Console.WriteLine("Сумма чисел от 1 до 10 равна {0}", sum);
    }
    static void Main(string[] args)
    {
        Stopwatch sWatch = new Stopwatch();
        Thread thread1 = new Thread(new ThreadStart(Sum));
        Thread thread2 = new Thread(new ThreadStart(Sum));
        sWatch.Start();
        thread1.Start();
        sWatch.Stop();
        Console.WriteLine("Милисекунд затрачено на выполнение 1-ого потока- " + sWatch.ElapsedMilliseconds.ToString());
        sWatch.Restart();
        thread2.Start();
        sWatch.Stop();
        Console.WriteLine("Милисекунд затрачено на выполнение 2-ого потока- " + sWatch.ElapsedMilliseconds.ToString());
        Console.ReadLine();
    }
}
