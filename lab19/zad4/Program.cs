using System;
using System.Collections;

namespace p4
{
    class Program
    {
        static void Main(string[] args)
        {

            Storage stor = new Storage();
            bool n = true;
            while (n == true)
            {
                Console.WriteLine("1)Добавить диск\n2)Удалить диск\n3)Добавить песню\n4)Удалить песню\n5)Просмотреть диск\n6)Просмотреть песни\n7)Выйти из программы");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        Console.WriteLine("Введите название диска:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите ключ диска:");
                        string key = Console.ReadLine();
                        AddDisk(stor, name, key);
                        break;

                    case "2":
                        Console.WriteLine("Введите ключ диска:");
                        string key1 = Console.ReadLine();
                        RemDisk(stor, key1);
                        break;

                    case "3":
                        Console.WriteLine("Введите название песни:");
                        string name1 = Console.ReadLine();
                        Console.WriteLine("Введите ключ песни(ключ должен совпадать с нужным вам диском):");
                        string key2 = Console.ReadLine();
                        AppendSound(stor, name1, key2);
                        break;

                    case "4":
                        Console.WriteLine("Введите ключ песни(ключ должен совпадать с нужным вам диском):");
                        string key3 = Console.ReadLine();
                        RemSound(stor, key3);
                        break;

                    case "5":
                        stor.GetDisks();
                        break;

                    case "6":
                        stor.GetSound();
                        break;
                    case "7":
                        n = false;
                        break;


                    default:
                        Console.WriteLine("Такого пункта нет!");
                        break;
                }
            }
        }

        static void AddDisk(Storage obj, string key, string name)
        {
            obj.Append(name, key);
        }

        static void RemDisk(Storage obj, string key)
        {
            obj.Rem(key);
        }

        static void AppendSound(Storage obj, string key, string name)
        {
            obj.AppendSound(name, key);
        }

        static void RemSound(Storage obj, string key)
        {
            obj.RemSound(key);
        }
    }
    class Storage
    {
        Hashtable hashdisk = new Hashtable();
        Hashtable hashsound = new Hashtable();
        public void Append(string key, string name)
        {
            Console.WriteLine();
            Console.WriteLine("Диск добавлен");
            hashdisk.Add(name, key);
            Console.WriteLine();
        }
        public void Rem(string key)
        {
            Console.WriteLine();
            Console.WriteLine("Диск удален");
            hashdisk.Remove(key);
            Console.WriteLine();
        }
        public void AppendSound(string key, string name)
        {
            Console.WriteLine();
            ICollection keys = hashdisk.Keys;
            if (key.Contains(key))
            {
                hashsound.Add(name, key);
                Console.WriteLine("Песня добавлена");
                Console.WriteLine();
            }
            else
                Console.WriteLine("Диска с таким ключом не существует!");
        }
        public void RemSound(string key)
        {
            Console.WriteLine();
            ICollection keys = hashdisk.Keys;
            if (key.Contains(key))
            {
                hashsound.Remove(key);
                Console.WriteLine("Песня удалена");
                Console.WriteLine();
            }
            else
                Console.WriteLine("Диска с таким ключом не существует!");
        }
        public void GetDisks()
        {
            Console.WriteLine();
            Console.WriteLine("Список дисков");
            ICollection keys = hashdisk.Keys;
            foreach (string s in keys)
                Console.WriteLine(s + ": " + hashdisk[s]);
            Console.WriteLine();
        }
        public void GetSound()
        {
            Console.WriteLine();
            Console.WriteLine("Список песен");
            ICollection keys = hashsound.Keys;
            foreach (string s in keys)
                Console.WriteLine(s + ": " + hashsound[s]);
            Console.WriteLine();
        }
    }
}