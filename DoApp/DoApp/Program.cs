namespace DoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //тоже объявить сумму? Обязательно же.
            var i = 0;
            var s = 0;
            do
            {
                Console.WriteLine(i);
                s = s + i;

                i = i + 1;
            }
            while (i < 21);

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