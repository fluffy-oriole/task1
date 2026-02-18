namespace task1
{
    public class Logic
    {
        public static int[] GetRubCents(int num) {
            int rub = num / 100;
            int cents = num % 100;
            return [rub, cents];
        }
        public static String GetCentsWord(int cents)
        {
            if (cents == 0)
            {
                return " ровно";
            }
            else if (cents > 10 && cents < 20)
            {
                return (cents.ToString() + " копеек");
            }
            else if (cents % 10 == 1)
            {
                return (cents.ToString() + " копейка");
            }
            else if (cents % 10 > 1 && cents % 10 < 5)
            {
                return (cents.ToString() + " копейки");
            }
            else
            {
                return (cents.ToString() + " копеек");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для преобразования: ");
            int num = int.Parse(Console.ReadLine());
            int rub = Logic.GetRubCents(num)[0];
            int cents = Logic.GetRubCents(num)[1];
            Console.Write(rub.ToString() + " руб. " + Logic.GetCentsWord(cents));
        }
    }
}