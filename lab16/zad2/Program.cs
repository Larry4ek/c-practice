using System;

namespace p2
{
    class MyDictionary<Tkey, Tval>
    {
        private int counter = 0;
        private Tkey[] keysArray = null;
        private Tval[] valsArray = null;
        public int Counter
        {
            get { return this.counter; }
        }
        public void Add(Tkey key, Tval val)
        {
            this.counter++;
            Array.Resize(ref keysArray, counter);
            keysArray[counter - 1] = key;
            Array.Resize(ref valsArray, counter);
            valsArray[counter - 1] = val;
        }
        public Tval this[Tkey key]
        {
            get
            {
                int ind = 0;
                for (int i = 0; i < keysArray.Length; i++)
                {
                    if (key.Equals(keysArray[i]))
                        ind = i;
                }
                return valsArray[ind];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(0, "Sport");
            Console.WriteLine(dictionary[0]);
            Console.WriteLine("Количество элементов после добавления = " + dictionary.Counter);
            dictionary.Add(1, "Run");
            Console.WriteLine(dictionary[1]);
            Console.WriteLine("Количество элементов = " + dictionary.Counter);
            Console.ReadKey();
        }
    }
}
