using static System.Console;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Employees Vladimir = Employees.Vladimir;
            Employees vadim = Employees.Vadim;
            Employees alex = Employees.Alex;
            Employees Jenya = Employees.Jenya;
            Employees Arthur = Employees.Arthur;
            Employees Serhio = Employees.Serhio;
            Employees Maximiliano = Employees.Maximiliano;

            string[] employeersNames = { "Vladimir", "vadim", "alex", "Jenya", "Arthur", "serhio", "Maximiliano" };
            printAllEmployers(employeersNames);

            Console.WriteLine("Введите имя сотрудника о котором хотите узнать информацию(для выходы из программы напишите exit): ");
            string employeeChecker = Console.ReadLine();

            switch (employeeChecker)
            {
                case "Vladimir":
                    EmployeeInformation(Vladimir);
                    break;
                case "vadim":
                    EmployeeInformation(vadim);
                    break;
                case "alex":
                    EmployeeInformation(alex);
                    break;
                case "Jenya":
                    EmployeeInformation(Jenya);
                    break;
                case "Arthur":
                    EmployeeInformation(Arthur);
                    break;
                case "Serhio":
                    EmployeeInformation(Serhio);
                    break;
                case "Maximiliano":
                    EmployeeInformation(Maximiliano);
                    break;
                case "exit:":
                    break;
            }
        }

        enum Employees
        {
            Vladimir = 10,
            Vadim = 20,
            Alex = 5,
            Jenya = 15,
            Arthur = 19,
            Serhio = 30,
            Maximiliano = 44,
        }

        static void EmployeeInformation(Employees employees)
        {
            switch (employees)
            {
                case Employees.Vladimir:
                    Console.WriteLine($"Сотруднику {Employees.Vladimir} требуется отработать:{(int)Employees.Vladimir} часов за месяц");
                    break;
                case Employees.Vadim:
                    Console.WriteLine($"Сотруднику {Employees.Vadim} требуется отработать:{(int)Employees.Vadim} часов за месяц");
                    break;
                case Employees.Alex:
                    Console.WriteLine($"Сотруднику {Employees.Alex} требуется отработать:{(int)Employees.Alex} часов за месяц");
                    break;
                case Employees.Jenya:
                    Console.WriteLine($"Сотруднику {Employees.Jenya} требуется отработать:{(int)Employees.Jenya} часов за месяц");
                    break;
                case Employees.Arthur:
                    Console.WriteLine($"Сотруднику {Employees.Arthur} требуется отработать:{(int)Employees.Arthur} часов за месяц");
                    break;
                case Employees.Serhio:
                    Console.WriteLine($"Сотруднику {Employees.Serhio} требуется отработать:{(int)Employees.Serhio} часов за месяц");
                    break;
                case Employees.Maximiliano:
                    Console.WriteLine($"Сотруднику {Employees.Maximiliano} требуется отработать:{(int)Employees.Maximiliano} часов за месяц");
                    break;
            }
        }
        static void printAllEmployers(string[] arr)
        {
            Console.WriteLine("Все сотрудники:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i + "." + arr[i]);
            }
        }
    }
}
