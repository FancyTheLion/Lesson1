namespace WhileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            var s = 0;
            while (i <= 20)
            {
                Console.WriteLine(i);
                s = s + i;

                i = i + 1;
            }

            Console.WriteLine($"Сумма: {s}");

            WaitForExit();
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