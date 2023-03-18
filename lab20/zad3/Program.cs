namespace MyNamespace
{
    class Program
    {
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
                    Operation operation1 = Add;
                    result = DelegateChecker(numberA, numberB, operation1);
                    Console.WriteLine(result);
                    break;
                case 2:
                    Operation operation2 = Subtraction;
                    result = DelegateChecker(numberA, numberB, operation2);
                    Console.WriteLine(result);
                    break;
                case 3:
                    Operation operation3 = Diversion;
                    result = DelegateChecker(numberA, numberB, operation3);
                    Console.WriteLine(result);
                    break;
                default: Console.WriteLine("Такой операции нет"); break;

            }
        }

        /// <summary>
        /// Method of check user chosen operation
        /// </summary>
        /// <param name="numberA"></param>
        /// <param name="numberB"></param>
        /// <param name="operation"></param>
        /// <returns> return result with chosen operation by user</returns>

        public static int DelegateChecker(int numberA, int numberB, Operation operation)
        {
            int result = operation(numberA, numberB);
            return result;

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
    /// <summary>
    /// Create delegate
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>returns operation</returns>
    delegate int Operation(int x, int y);
}