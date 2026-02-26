namespace task1
{
    public class Logic
    {
        public static String GetRubCents(int num)
        {
            int rub = num / 100;
            int cents = num % 100;
            String answer = rub.ToString();
            if (rub % 10 == 1)
            {
                answer += " рубль ";
            }
            else if (rub % 10 >= 2 && rub % 10 <= 4)
            {
                answer += " рубля ";
            }
            else
            {
                answer += " рублей ";
            }
            if (cents == 0)
            {
                answer += "ровно";
            }
            else if (cents > 10 && cents < 20)
            {
                answer += (cents.ToString() + " копеек");
            }
            else if (cents % 10 == 1)
            {
                answer += (cents.ToString() + " копейка");
            }
            else if (cents % 10 > 1 && cents % 10 < 5)
            {
                answer += (cents.ToString() + " копейки");
            }
            else
            {
                answer += (cents.ToString() + " копеек");
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