class MyList<T>
{
    private T[] myList = null;
    public T this[int index]
    {
        get { return myList[index]; }
        set { myList[index] = value; }
    }
    public MyList()
    {
        this.myList = new T[1];
    }
    public MyList(int count)
    {
        this.myList = new T[count];
    }
    public void Add(T item)
    {
        if (myList == null)
        {
            myList = new T[1];
            myList[0] = item;
        }
        else
        {
            int length = myList.Length;
            Array.Resize(ref myList, length + 1);
            myList[length] = item;
        }

    }
    public int Capacity
    {
        get
        {
            return myList.Length;
        }
    }
    public int Count
    {
        get
        {
            int count = 0;
            for (int i = 0; i < myList.Length; i++)
            {
                if (myList[i].ToString() != null)
                {
                    count++;
                }
            }
            return count;
        }
    }
    public void Info()
    {
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyList<int> mylist = new MyList<int>();
        Console.WriteLine("Введите емкость: ");
        mylist[0] = int.Parse(Console.ReadLine());
        Console.WriteLine("Емкость списка: {0}", mylist.Capacity);
        Console.WriteLine("Список фактически содержит: {0}", mylist.Count);
        mylist.Add(10);
        Console.WriteLine("Список после добавления: {0}", mylist.Capacity);

        mylist.Info();
        mylist.Add(25);
        Console.WriteLine("After");
        mylist.Info();
        Console.ReadLine();
    }
}
