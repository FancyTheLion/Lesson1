namespace ForApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var s = 0;

            for (var i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
                s = s + i;
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