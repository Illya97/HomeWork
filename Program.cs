using System;

namespace Home_Work4_3Easy
{
    class Program
    {
        static void Main(string[] args)
        {
        
            char[] arr = new char[10];
            arr[0] = '@';
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = '_';
            }
            //----------------------------------------
            Boolean finish = true;
            char temp = ' ';
            int hp = 100; 
            do
            {
                if (arr[arr.Length - 1] == '@')
                {
                    finish = false;
                    break;
                }
                // Вивод масива
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + "");

                }
                Console.WriteLine("");
                Console.WriteLine("Введите действие: a - движение влево, d - движение вправо.");
                string run = Console.ReadLine();
                if (run == "a" && arr[0] != '@')
                {
                    temp = arr[0];
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        arr[i] = arr[i + 1];
                    }
                    arr[arr.Length - 1] = temp;
                    hp -= 5;
                }
                else if (run == "d")
                {
                    temp = arr[arr.Length - 1];
                    for (int i = arr.Length - 1; i > 0; i--)
                    {
                        arr[i] = arr[i - 1];
                    }
                    arr[0] = temp;
                    hp -= 5;
                }

            } while (finish && hp > 0);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "");
            }
            Console.WriteLine("");
            Console.WriteLine("Game Over");
        }
    }
}
