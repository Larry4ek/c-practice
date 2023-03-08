using System;
using System.Collections.Generic;

namespace TEST
{
    class Program
    {
        static string[] pars = new string[4];
        static List<Apartment> ap1 = new List<Apartment>();
        static List<ApartmentsInTheCenter> ap2 = new List<ApartmentsInTheCenter>();
        static void Main(string[] args)
        {
            char temp;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите действие");
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("1) Создать объект класса Квартира");
                Console.WriteLine("2) Создать объект класса Квартира в центре");
                Console.WriteLine("3) Вывести все поля объектов");
                Console.WriteLine("4) Вывести стоимости квартир");
                Console.WriteLine("0) Выход");
                Console.WriteLine(new string('-', 50));

                temp = Console.ReadLine()[0];
                switch (temp)
                {
                    case '1':
                        First();
                        break;
                    case '2':
                        Second();
                        break;
                    case '3':
                        GetAllPars();
                        break;
                    case '4':
                        GetCosts();
                        break;
                    case '0':
                        Environment.Exit(1);
                        break;
                    default:
                        break;
                }
            }
        }

        static void First()
        {
            Console.Clear();
            Console.WriteLine("Создание объекта класса Квартира");
            Console.WriteLine(new string('-', 40));
            Console.Write("Название: ");
            pars[0] = Console.ReadLine();
            Console.Write("Стоимость 1 кв. метра: ");
            pars[1] = Console.ReadLine().Replace('.', ',');
            Console.Write("Площадь: ");
            pars[2] = Console.ReadLine().Replace('.', ',');
            ap1.Add(new Apartment(pars[0], double.Parse(pars[1]), double.Parse(pars[2])));
            Console.Clear();
            Console.WriteLine("Успешно!");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadLine();
        }

        static void Second()
        {
            Console.Clear();
            Console.WriteLine("Создание объекта класса Квартира в центре");
            Console.WriteLine(new string('-', 40));
            Console.Write("Название района: ");
            pars[0] = Console.ReadLine(); ;
            Console.Write("Название квартиры: ");
            pars[1] = Console.ReadLine();
            Console.Write("Стоимость 1 кв. метра: ");
            pars[2] = Console.ReadLine().Replace('.', ',');
            Console.Write("Площадь: ");
            pars[3] = Console.ReadLine().Replace('.', ',');
            ap2.Add(new ApartmentsInTheCenter(pars[0], pars[1], double.Parse(pars[2]), double.Parse(pars[3])));
            Console.Clear();
            Console.WriteLine("Успешно!");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadLine();
        }

        static void GetAllPars()
        {
            Console.Clear();
            Console.WriteLine("Поля объектов");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Квартиры:");
            foreach (var x in ap1)
            {
                Console.WriteLine("-{0}:", x.Name);
                Console.WriteLine("--Стоимость 1 кв. метра: {0}", x.CostPerSquareMeter);
                Console.WriteLine("--Площадь: {0}", x.Square);
            }
            Console.WriteLine("Квартиры в центре:");
            foreach (var x in ap2)
            {
                Console.WriteLine("-{0}:", x.Name);
                Console.WriteLine("--Район: {0}", x.DistrictName);
                Console.WriteLine("--Стоимость 1 кв. метра: {0}", x.CostPerSquareMeter);
                Console.WriteLine("--Площадь: {0}", x.Square);
            }
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadLine();
        }

        static void GetCosts()
        {
            Console.Clear();
            Console.WriteLine("Стоимости квартир");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Квартиры:");
            foreach (var x in ap1)
            {
                Console.WriteLine("-{0}: {1}", x.Name, x.GetApartmentCost());
            }
            Console.WriteLine("Квартиры в центре:");
            foreach (var x in ap2)
            {
                Console.WriteLine("-{0}: {1}", x.Name, x.GetApartmentCost());
            }
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadLine();
        }
    }

    class Apartment
    {
        private string name;
        private double costPerSquareMeter;
        private double square;

        public string Name { get => name; set => name = value; }
        public double CostPerSquareMeter { get => costPerSquareMeter; set => costPerSquareMeter = value; }
        public double Square { get => square; set => square = value; }

        public Apartment(string name, double cost, double square)
        {
            Name = name;
            CostPerSquareMeter = cost;
            Square = square;
        }

        public virtual string[] WritePars() => new[] { Name, CostPerSquareMeter.ToString(), Square.ToString() };
        public virtual double GetApartmentCost() => CostPerSquareMeter * Square;
    }

    class ApartmentsInTheCenter : Apartment
    {
        private string districtName;

        public string DistrictName { get => districtName; set => districtName = value; }

        public ApartmentsInTheCenter(string distName, string name, double cost, double square) : base(name, cost, square)
        {
            DistrictName = distName;
        }

        public override string[] WritePars() => new[] { DistrictName, Name, CostPerSquareMeter.ToString(), Square.ToString() };
        public override double GetApartmentCost() => base.GetApartmentCost() * 1.01;
    }
}