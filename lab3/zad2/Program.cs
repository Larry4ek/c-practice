using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructApp
{
    class Employee : Worker
    {
        public void make()
        {
            Console.WriteLine("Рабочий ждёт когда ему дадут работу.");
        }
    }
    class Engineer
    {
        public string place;
        public void make()
        {
            Console.Write("Инженер работает на " + place);
        }
    }
    class Worker
    {
        public string instrument;
        public void make()
        {
            Console.WriteLine(", его инструмент это " + instrument + ".");
        }
    }
    class Personal : Engineer
    {
        public void make()
        {
            Console.WriteLine("Персонал работает в " + place + ".");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employees = new Employee();
            Employees.make();
            Engineer Engineers= new Engineer();
            Engineers.place = "заводе";
            Engineers.make();
            Worker workers= new Worker();
            workers.instrument = "молоток";
            workers.make();
            Personal Personals = new Personal();
            Personals.place = "офисе";
            Personals.make();

            Console.ReadKey();
        }
    }
}