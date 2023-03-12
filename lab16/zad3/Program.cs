using System;
using System.Collections.Generic;

namespace p3
{

    public class MyList<T>
    {
        public static T session;
        public List<T> lst = new List<T>();

        static int count;

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = lst.Count;
            }
        }

        public void Add(T value)
        {
            lst.Add(value);
        }

        public void Remove(T value)
        {
            lst.Remove(value);
        }

        public void PrintList()
        {
            Console.WriteLine("Список:");
            foreach (var item in lst)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
        }
        public void GetIndex(int index)
        {
            if (lst.Count >= index)
            {
                Console.WriteLine("Значение с индеком {0}:{1}", index, lst[index]);
            }
            else
            {
                Console.WriteLine("Элемента с индексом {0} не существует!", index);
            }
        }
    }
    public static class StaticClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.lst.Count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = list.lst[i];
            }
            return array;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mylst = new MyList<int>();
            MyList<int>.session = 100;
            mylst.Add(9999);
            mylst.Add(1);
            mylst.Add(123);
            mylst.Add(87);
            mylst.Add(1);
            mylst.Add(321);
            mylst.Remove(200);
            mylst.PrintList();
            mylst.GetIndex(1);
            mylst.Count = 0;
            Console.WriteLine("Количество элементов списка:" + mylst.Count);
            Console.WriteLine("Массив:");
            int[] array = StaticClass.GetArray<int>(mylst);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }
        }
    }
}

