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
            Console.Write(rub.ToString() + " руб. ");
            if (cents == 0)
            {
                Console.Write("ровно");
            }
            else if (cents > 10 && cents < 20)
            {

                Console.Write(cents.ToString() + " копеек");
            }
            else if (cents % 10 == 1)
            {
                Console.Write(cents.ToString() + " копейка");
            }
            else if (cents % 10 > 1 && cents % 10 < 5)
            {
                Console.Write(cents.ToString() + " копейки");
            }
            else
            {
                Console.Write(cents.ToString() + " копеек");
            }

        }
    }
}
