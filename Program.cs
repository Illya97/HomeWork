using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Згенерировать число 
            Random rnd = new Random();
            int сorrect_number = rnd.Next(0,100);
            byte count = 1;
       
            while (count!=6) {
                    //Ввод числа пользователем
                    Console.WriteLine("Try#" + count);
                    Console.Write("Enter your number from 0 to 100: ");
                    byte user_number = Convert.ToByte(Console.ReadLine());
                    Console.Write("");
                // Проверка на правильность ввода
                if (user_number < 0 || user_number > 100)
                    {
                        Console.WriteLine("Enter correct number.");
                    continue;
                    }
                //Подсказки для пользователя и выход с цикла если пользователь угадал число 
                if (user_number < сorrect_number)
                {
                    Console.WriteLine("Wrong!My number is bigger!");
                }
                else if (user_number > сorrect_number)
                {
                    Console.WriteLine("Wrong!My number is smaller!");
                }
                else
                {
                    Console.WriteLine("You win!!!Congratulations, your score:"+ count+";");
                    break;
                }
                count++;
            }
            Console.WriteLine("You lost! Try again. My numbe is "+ сorrect_number+".");



        }
    }
}
