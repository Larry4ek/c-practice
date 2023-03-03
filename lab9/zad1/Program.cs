using System;
using System.Linq;

namespace Numb1
{
    struct Student
    {
        public string familiya; // public модификатор доступа 
        public int Kolvo;
        public double[] ocenki;
        public Student(string name, int number, double[] time)
        {
            this.familiya = name; //this ссылается на текущий экземпляр класса
            this.Kolvo = number;
            this.ocenki = time;
        }
        public override string ToString() //Метод override предоставляет новую реализацию метода, унаследованного от базового класса
        {
            return $"{familiya},{Kolvo},{ocenki}";
        }
    }
    class Program

    {
        static void Main(string[] args)
        {
            int count;
            Console.WriteLine("Введите количество студентов:");
            count = Convert.ToInt32(Console.ReadLine());
            Student[] students = new Student[count];
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Введите фамилию и инициалы");
                string name = Console.ReadLine();
                Console.WriteLine("Введите номер группы");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите успеваемость (массив из пяти элементов)");
                double[] uspevaemost = new double[5];
                for (int j = 0; j < 5; j++)
                {
                    uspevaemost[j] = double.Parse(Console.ReadLine());
                }
                students[i] = new Student(name, number, uspevaemost);
            }
            Console.WriteLine("Фамилия и инициалы, номер группы,  успеваемость (массив из пяти элементов):");
            Console.WriteLine("Студенты, имеющие оценки 4 и 5: ");
            Boolean bol = true;
            foreach (var item in students) //foreach предназначен для перебора элементов массива
            {
                if (item.ocenki.Min() > 3)
                {
                    Console.WriteLine(item.familiya);
                    Console.WriteLine(item.Kolvo);
                    foreach (var otmetki in item.ocenki)
                    {
                        Console.Write($"{otmetki} ");
                    }
                    bol = false;
                }
            }
            if (bol)
            {
                Console.WriteLine($"Студенты, имеющие оценки 4 и 5 отсутствуют");

            }
            Console.ReadLine();
        }
    }
}

