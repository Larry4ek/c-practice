class Demo
{
    static void Main()
    {
        string s1 = "asdfghj";
        string s2 = "jhgfdsa";
        Stack<char> chStack = new Stack<char>();
        foreach (char ch in s1)
            chStack.Push(ch);
        int j = 0;
        bool flag = true;
        while (chStack.Count != 0)
        {
            if (s2[j] != chStack.Pop())
            {
                flag = false;
                break;
            }
            j++;
        }
        Console.WriteLine("Строка s1: {0}, строка s2: {1}", s1, s2);
        Console.WriteLine("{0}", (flag) ? "строки обратны друг другу" : "строки не обратны друг другу");
    }
}
