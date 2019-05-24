using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = 0;
            ushort total = 357;
            if (total >= 500)
            {
                discount = 7;
            }
            else if (total >= 400)
            {
                discount = 5;

            }
            else if (total >= 300)
            {
                discount = 3;
                
            }
            Console.WriteLine("Скидка:" + discount + "; Сума к оплате:" + (total - ((total*discount)/100.00)) + ";");
        }
    }
}
