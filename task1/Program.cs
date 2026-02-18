namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для преобразования: ");
            int num = int.Parse(Console.ReadLine());
            int rub = num / 100;
            int cents = num % 100;
            Console.Write(rub.ToString() + " руб. " + cents + " копеек");
        }
    }
}
