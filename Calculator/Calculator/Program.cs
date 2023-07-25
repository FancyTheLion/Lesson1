namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Calculate();

                AskForExit();
            }
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
                var enteredString = Console.ReadLine();

                if (double.TryParse(enteredString, out result) == true)
                {
                    return result;
                }

                Console.WriteLine("Вы ввели не число, повторите попытку!");
            }
        }

        public static bool EnterBool()
        {
            Console.WriteLine("Введите true или false:");

            var enteredString = Console.ReadLine();

            return bool.Parse(enteredString);
        }

        /// <summary>
        /// В этом методе происходит одно действие
        /// </summary>
        public static void Calculate()
        {
            var a = EnterNumber("A");
            var b = EnterNumber("B");

            var c = EnterBool();
            if (c)
            {
                Console.WriteLine("Вы ввели истину.");
            }
            else
            {
                Console.WriteLine("Вы ввели ложь.");
            }

            Console.WriteLine("Введите + для сложения,");
            Console.WriteLine("Введите - для вычитания,");
            Console.WriteLine("Введите / для деления,");
            Console.WriteLine("Введите * для умножения.");

            double result = 0;

            var operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    result = Add(a, b);
                    break;

                case "-":
                    result = Diff(a, b);
                    break;

                case "*":
                    result = a * b;
                    break;

                case "/":
                    result = a / b;
                    break;

                default:
                    Console.WriteLine("Введена неверная операция");
                    Environment.Exit(1);
                    break;
            }

            Console.WriteLine($"Результат: {result}");
            Console.WriteLine($"Квадратный корень результата: {SquareRoot(result)}");
        }

        /// <summary>
        /// Метод складывает два числа
        /// </summary>
        /// <param name="x">Первое слагаемое</param>
        /// <param name="y">Второе слагаемое</param>
        /// <returns>Сумма</returns>
        public static double Add(double x, double y)
        {
            Console.WriteLine($"Сложение {x} и {y}");

            double s;
            s = x + y;
            return s;
        }

        /// <summary>
        /// Метод вычитает два числа
        /// </summary>
        /// <param name="x">Уменьшаемое</param>
        /// <param name="y">Вычитаемое</param>
        /// <returns>Разность</returns>
        public static double Diff(double x, double y)
        {
            Console.WriteLine($"Из {x} вычитаем {y}");

            return x - y;
        }

        /// <summary>
        /// Метод вычисляет квадратный корень
        /// </summary>
        public static double SquareRoot(double r)
        {
            Console.WriteLine($"Вычисляем квадратный корень из {r}");

            return Math.Sqrt(r);
        }


        /// <summary>
        /// Метод завершает программу если пользователь согласен
        /// </summary>
        public static void AskForExit()
        {
            while (true)
            {
                // Если пользователь вводит "Да" - то мы выходим
                Console.WriteLine("Завершить программу?");

                var answer = Console.ReadLine();
                answer = answer.ToLower(); // нЕт -> нет, дА -> да, Да -> да

                if (answer == "да")
                {
                    // Я выполнюсь, если пользователь напечатал "Да"
                    Environment.Exit(0);
                }
                else if (answer == "нет")
                {
                    // Я выполняюсь, если пользователь напечатал "Нет"
                    return; // Выполнение метода завершилось, управление передано туда, где метод был вызван.
                }

                // Я выполняюсь, если не сработало ни одно из условий выше
                Console.WriteLine("Вы должны ввести \"Да\" или \"Нет\"");
            }
        }
    }
}