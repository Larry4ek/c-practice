namespace MyNamespace
{
    class Program
    {
        /// <summary>
        /// Create delegate
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>returns operation</returns>
        delegate int Operation(int x, int y);

        public static void Main()
        {
            Console.WriteLine("Введите номер операции которую хотите выбрать(1 - сумма, 2 - вычитание, 3 - умножение)");
            int chosenOperation = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число а:");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int numberB = Convert.ToInt32(Console.ReadLine());
            int result;
            switch (chosenOperation)
            {
                case 1:
                    Operation operation = Add;
                    result = operation(numberA, numberB);
                    Console.WriteLine(result);
                    break;
                case 2:
                    Operation operation1 = Subtraction;
                    result = operation1(numberA, numberB);
                    Console.WriteLine(result);
                    break;
                case 3:
                    Operation operation2 = Diversion;
                    result = operation2(numberA, numberB);
                    Console.WriteLine(result);
                    break;
                default: Console.WriteLine("Такой операции нет"); break;

            }
        }

        /// <summary>
        /// Method of summarise 2 numbers
        /// </summary>
        /// <param name="numberA"></param>
        /// <param name="numberB"></param>
        /// <returns>result of summarise</returns>

        public static int Add(int numberA, int numberB)
        {
            Console.WriteLine("Операция сложения");
            int result = numberA + numberB;

            return result;
        }

        /// <summary>
        /// Method of subtraction 2 numbers
        /// </summary>
        /// <param name="numberA"></param>
        /// <param name="numberB"></param>
        /// <returns>returns result subtraction of 2 numbers</returns>

        public static int Subtraction(int numberA, int numberB)
        {
            Console.WriteLine("Операция вычитания");
            int result = numberA - numberB;

            return result;
        }

        /// <summary>
        /// Method of diversion 2 numbers
        /// </summary>
        /// <param name="numberA"></param>
        /// <param name="numberB"></param>
        /// <returns> return result of diversion 2 numbers</returns>

        public static int Diversion(int numberA, int numberB)
        {
            Console.WriteLine("Операция деления");
            int result = numberA / numberB;

            return result;
        }
    }
}