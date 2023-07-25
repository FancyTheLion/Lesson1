namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = EnterNumber("первое");
            var b = EnterNumber("второе");

            var result = 0.0;

            Console.WriteLine("Введите операцию: +,-,*,/");
            var o = Console.ReadLine();

            switch (o)
            {
                case "+":
                    result = a + b;
                    break;

                case "-":
                    result = a - b;
                    break;

                case "*":
                    result = a * b;
                    break;

                case "/":
                    result = a / b;
                    break;
            }

            Console.WriteLine($"Результат: {result}");

            Console.WriteLine("Нажмите Enter для выхода");
            Console.ReadLine();
        }

        public static double EnterNumber(string numberName)
        {
            Console.WriteLine($"Введите { numberName} число");

            var s = Console.ReadLine();
            var number = double.Parse(s); // double.Parse() - принять строку в круглые скобки,
            // проанализировать её и если получится - сделать из неё число. Если не получится - упасть

            return number; // Переменная после слова return возвращается в double у имени метода
        }
    }
}