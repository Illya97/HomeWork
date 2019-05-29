using System;

namespace HomeWork3_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = 0;
            Console.WriteLine("Enter total money:");
            int total = Convert.ToInt32(Console.ReadLine());
            switch (total >0 && total<300)
            {
                case true:
                    discount = 0;
                    break;
            }
            switch (total >= 300 && total < 400)
            {
                case true:
                    discount = 3;
                    break;
            }
            switch (total >= 400 && total <  500)
            {
                case true:
                    discount = 5;
                    break;
            }
            switch (total >= 500)
            {
                case true:
                    discount = 7;
                    break;
            }
            
            Console.WriteLine("Скидка:" + discount + "%; Сума к оплате:" + (total - ((total * discount) / 100.00)) + ";");
        }
    }
}
