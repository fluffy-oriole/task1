namespace task1
{
    public class Logic
    {
        public static String GetRubCents(int num)
        {
            int rub = num / 100;
            int cents = num % 100;
            String answer = rub.ToString();
            if (cents == 0)
            {
                answer += " руб. ровно";
            }
            else if (cents > 10 && cents < 20)
            {
                answer += (" руб. " + cents.ToString() + " копеек");
            }
            else if (cents % 10 == 1)
            {
                answer += (" руб. " + cents.ToString() + " копейка");
            }
            else if (cents % 10 > 1 && cents % 10 < 5)
            {
                answer += (" руб. " + cents.ToString() + " копейки");
            }
            else
            {
                answer += " руб. " + (cents.ToString() + " копеек");
            }
            return answer;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для преобразования: ");
            int num = int.Parse(Console.ReadLine());
            String answer = Logic.GetRubCents(num);
            Console.Write(answer);
        }
    }
}