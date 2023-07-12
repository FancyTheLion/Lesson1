namespace HelloWorldApp // Это пространство имён - в нём лежит всё
{
    /// <summary>
    /// Это класс. Класс - это набор кода и переменных.
    /// Код называется методами(действие). Переменные называются свойствами(описание).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Это метод Main() - главный метод программы
        /// static - не требуется создание объекта
        /// void - метод ничего не возвращает
        /// Main - название метода
        /// string[] args - это параметры метода (это данные, которые приходят на вход в метод)
        /// </summary>
        static void Main(string[] args)
        {
            var a = EnterNumber("A");
            var b = EnterNumber("B");

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");

            WaitForExit();
        }

        /// <summary>
        /// Метод ввода числа с клавиатуры
        /// </summary>
        /// <param name="numberName">Имя числа (оно будет распечатываться на экране)</param>
        /// <returns>Введённое число</returns>
        static double EnterNumber(string numberName)
        {
            while (true)
            {
                Console.WriteLine($"Введите число {numberName}");

                double result; // Объявили переменную с именем result типа double

                // Читаем с консоли строку, пытаемся её превратить в число, проверяем, успешно-ли
                if (double.TryParse(Console.ReadLine(), out result) == true)
                {
                    return result;
                }

                Console.WriteLine("Вы ввели не число, повторите попытку!");
            }
        }

        /// <summary>
        /// Это новый метод. Он называется WaiteForExit
        /// Он ничего не возвращает (void)
        /// Он ничего не принимает от других частей программы - пустые скобки
        /// </summary>
        static void WaitForExit()
        {
            Console.WriteLine("Нажмите y для завершения");

            // Это - переменная (то есть данные)
            // У переменных есть тип (какие данные в ней), имя и значение
            // Тип нашей переменной ConsoleKeyInfo - информация о нажатой клавише
            // Имя нашей переменной - enteredKey
            // Значение ещё не присвоено
            ConsoleKeyInfo enteredKey;

            do // Начало цикла - повторяющихся действий
            {
                // Здесь мы вызываем метод ReadKey() у класса Console
                // Метод ReadKey() возвращает данные - информацию о том, какая сейчас нажата
                // клавиша.
                // Мы присваиваем эти данные в переменную при помощи знака =
                enteredKey = Console.ReadKey();
            }
            while (enteredKey.KeyChar != 'y'); // Условие выхода из цикла
            // Пока свойство KeyChar (знак на кнопке) информации о кнопке не равно
            // символу 'y' - повторять цикл.
        }
    }
}