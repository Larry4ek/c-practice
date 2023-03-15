using ClassLibrary;
using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Создайте свою машину");
            Console.WriteLine("Введите название марки: ");
            string carName = Console.ReadLine();
            Console.WriteLine("Введите год выпуска: ");
            string yearOfRelease = Console.ReadLine();
            Console.WriteLine("Введите обьем двигателя: ");
            double engineCapacity = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену автомобиля: ");
            decimal carPrice = Convert.ToDecimal(Console.ReadLine());
            bool isOnParking = false;
            CarsPark carsPark = new CarsPark(carName, yearOfRelease, engineCapacity, carPrice, isOnParking);

            Console.WriteLine("Вы хотите узнать где ваш автомобиль 1 - да, 2 - нет");
            int checkNumber = Convert.ToInt32(Console.ReadLine());
            switch (checkNumber)
            {
                case 1:
                    bool whereCar = carsPark.CheckParking(isOnParking);
                    if (whereCar)
                    {
                        Console.WriteLine("Ваш автомобиль на парковке");
                        Console.WriteLine("Хотите убрать его с парковки 1 - да, 2 - нет");
                        int needToRemoveCheck = Convert.ToInt32(Console.ReadLine());
                        if (needToRemoveCheck == 1)
                        {
                            carsPark.RemoveFromParking();
                            Console.WriteLine($"Автомобиль находится на парковке?{carsPark.isonparking}");
                        }
                        else if (needToRemoveCheck == 2)
                        {
                            Console.WriteLine("Автомобиль остается на парковке");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ваш автомобиль не на парковке");
                        Console.WriteLine("Хотите поставить его на парковку 1 - да, 2 - нет");
                        int needToAddCheck = Convert.ToInt32(Console.ReadLine());
                        if (needToAddCheck == 1)
                        {
                            carsPark.AddToParking();
                            Console.WriteLine($"Автомобиль находится на парковке?{carsPark.isonparking}");
                        }
                        else if (needToAddCheck == 2)
                        {
                            Console.WriteLine("Автомобиль остается на улице");
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Выберите операцию: 1 - информация о автомобиле");
                    int carOperation = Convert.ToInt32(Console.ReadLine());
                    switch (carOperation)
                    {
                        case 1:
                            Console.Write($"Марка автомобиля: {carsPark.carname}\n" + $"Год выпуска: {carsPark.yearofrelease}\n" + $"Обьем двигателя:{carsPark.enginecapacity}\n" + $"Цена автомобиля: {carsPark.carprice}\n" + $"Ваш авто на парковке: {carsPark.isonparking}\n");
                            break;

                    }

                    break;
                default: Console.WriteLine("Неверный номер операции"); break;

            }
        }
    }
}