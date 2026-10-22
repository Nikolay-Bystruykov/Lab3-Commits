namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");

            // Сумма двух чисел
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Сумма: {a + b}");
        }
    }
}
