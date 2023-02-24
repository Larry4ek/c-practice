using System;

internal class Program
{

    private static void Main()
    {

        Console.WriteLine("Введите минимум для счетчика");
        var min = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        Console.WriteLine("Введите максимум для счетчика");
        var max = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        Console.WriteLine("Введите значение для счетчика");
        var v = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        var counter = new Counter(max, min, v);
        Console.WriteLine("Введите + для увеличение и - для уменьшения, чтобы выйти нажмите любую клавишу!");

        do
        {
            var c = Console.ReadKey();
            if (c.KeyChar == '+') counter.Increase();
            else if (c.KeyChar == '-') counter.Decrease();
            else break;
            Console.WriteLine($" => {counter.Value}");
        } while (true);
        Console.ReadKey();

    }

}

public class Counter
{
    public readonly int Maximum;
    public readonly int Minimum;
    public int Value { private set; get; }
    public Counter(int maximum, int minimum, int counter)
    {
        this.Maximum = maximum;
        this.Minimum = minimum;
        counter = Math.Min(this.Maximum, counter);
        counter = Math.Max(this.Minimum, counter);
        this.Value = counter;
    }

    private Counter()
    {
        this.Maximum = 10;
        this.Minimum = 0;
        this.Value = 5;
    }

    public void Increase()
    {
        var value = this.Value + 1;
        if (value > this.Maximum || value < this.Minimum)
            return;
        this.Value++;

    }

    public void Decrease()
    {
        var value = this.Value - 1;
        if (value > this.Maximum || value < this.Minimum)
            return;
        this.Value--;

    }

}