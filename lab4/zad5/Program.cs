using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Library
    {
        public int Number
        {
            get; // исправить, получение значения свойства
            set; // установка значения свойства (методы доступа)
        }
        public string Author
        {
            get;
            set;
        }
        public int Year
        {
            get;
            set;
        }
        public string Category
        {
            get;
            set;
        }

        List<Library> LibraryList = new List<Library>();

        public void Add(Library Library)
        {
            LibraryList.Add(Library);
        }

        public void Remove(Library Library)
        {
            LibraryList.Remove(Library);

        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            Library objLibrary = obj as Library;
            if (objLibrary == null)
                return false;
            return true;
        }

        public override string ToString()
        {
            return Number + " " + Author + " " + Year + " " + Category;
        }

        public void ShowScreen()
        {
            foreach (var VARIABLE in LibraryList)
            {
                Console.WriteLine(VARIABLE.ToString());
            }
            Console.WriteLine("\n");
        }

        public void Search(string str, int number)
        {

            foreach (var VARIABLE in LibraryList)
            {
                if (number == 1 && VARIABLE.Author == str)
                {
                    Console.WriteLine(VARIABLE.ToString());
                }
                else if (number == 2 && VARIABLE.Year == Convert.ToInt32(str))
                {
                    Console.WriteLine(VARIABLE.ToString());
                }
                else if (number == 3 && VARIABLE.Category == str)
                {
                    Console.WriteLine(VARIABLE.ToString());
                }
                else if (number == 4 && VARIABLE.Number == Convert.ToInt32(str))
                {
                    Console.WriteLine(VARIABLE.ToString());
                }
            }


        }
        static void Main(string[] args)
        {
            Library Library = new Library();
            Library.Add(new Library { Number = 1, Author = "Ессенин", Year = 1900, Category = "Стихи" });
            Library.Add(new Library { Number = 2, Author = "Пушкин", Year = 1910, Category = "Рассказы" });
            Library.Add(new Library { Number = 3, Author = "Лермонтов", Year = 1920, Category = "Басни" });
            Library.Add(new Library { Number = 4, Author = "Достоевский", Year = 1910, Category = "Стихи" });
            Library.ShowScreen();
            Library.Remove(new Library { Number = 3, Author = "Лермонтов", Year = 1920, Category = "Басни" });
            Library.ShowScreen();

            Console.WriteLine("По какому критерию будем производить поиск? (По автору-1, год издания-2, по категории-3," +
                              "по номеру -4)");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Введите  писателя");
                    Library.Search(Console.ReadLine(), number);
                    break;
                case 2:
                    Console.WriteLine("Введите  год издания");
                    Library.Search(Console.ReadLine(), number);
                    break;
                case 3:
                    Console.WriteLine("Введите  категорию");
                    Library.Search(Console.ReadLine(), number);
                    break;
                case 4:
                    Console.WriteLine("Введите  номер книги");
                    Library.Search(Console.ReadLine(), number);
                    break;
                default:
                    Console.WriteLine("Не правильный критерий");
                    break;
            }

            Console.ReadLine();
        }

    }
}