namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = EnterNumber("A");
            var b = EnterNumber("B");

            Console.WriteLine("Введите + для сложения,");
            Console.WriteLine("Введите - для вычитания,");
            Console.WriteLine("Введите / для деления,");
            Console.WriteLine("Введите * для умножения.");

            double result = 0;

            var operation = Console.ReadLine();

            if (operation == "+")
            {
                result = a + b;
            }
            else if (operation == "-")
            {
                result = a - b;
            }
            else if (operation == "/")
            {
                result = a / b;
            }
            else if (operation == "*")
            {
                result = a * b;
            }
            else
            {
                Console.WriteLine("Введена неверная операция");
                WaitForExit();
                Environment.Exit(1);
            }

            Console.WriteLine($"Результат: {result}");

            WaitForExit();
        }

        /// <summary>
        /// Метод ввода числа с клавиатуры
        /// </summary>
        public static double EnterNumber(string n)
        {
            while (true)
            {
                Console.WriteLine($"Введите число {n}");

                double result;

                if (double.TryParse(Console.ReadLine(), out result) == true)
                {
                    return result;
                }

                Console.WriteLine("Вы ввели не число, повторите попытку!");
            }
        }

        /// <summary>
        /// Ждать нажатия y
        /// </summary>
        public static void WaitForExit()
        {
            Console.WriteLine("Нажмите y для завершения");

            ConsoleKeyInfo enteredKey;

            do
            {
                enteredKey = Console.ReadKey();
            }
            while (enteredKey.KeyChar != 'y');
        }
    }
}