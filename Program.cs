using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int discount0 = 0;
            const int discount3 = 3;
            const int discount5 = 5;
            const int discount7 = 7;
            ushort total = 357;
            double a = (total * discount7) / 100.00;
            double b = (total * discount5) / 100.00;
            double c = (total * discount3) / 100.00;
            if (total >= 500)
            {
                Console.WriteLine("Скидка:" + discount7 + "; Сума к оплате:" + (total - a) + ";");
            }
            else if (total >= 400)
            {
                Console.WriteLine("Скидка:" + discount5 + "; Сума к оплате:" + (total - b) + ";");
            }
            else if (total >= 300)
            {
                Console.WriteLine("Скидка:" + discount3 + "; Сума к оплате:" + (total - c) + ";");
            }
            else
            {
                Console.WriteLine("Скидка:" + discount0 + "; Сума к оплате:" + total + ";");
            }
        }
    }
}
