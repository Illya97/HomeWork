using System;

namespace HomeWork4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] arr_byte = new byte[10];
            short[] arr_short = new short[10];
            int[] arr_int = new int[10];
            int flag_byte = 0;
            int flag_short = 0;
            int flag_int = 0;
            long count = 0;
            Random rnd = new Random();
            
          while (flag_int<9) {
                int rnd_Number = rnd.Next(2147483647);
                if (rnd_Number>=255 & flag_byte<9)
            {
                arr_byte[flag_byte] = (byte)rnd_Number;
                flag_byte++;
                count++;
            }else if (rnd_Number >= 32767 & flag_short <9)
            {
                arr_short[flag_short] = (short)rnd_Number;
                flag_short++;
                count++;
            }
            else if (rnd_Number >= 2147483647 & flag_int < 9)
                {
                    arr_int[flag_int] = rnd_Number;
                    flag_int++;
                    count++;
                }
          }
          
           
            Console.WriteLine(flag_byte+flag_short+flag_int );
        }
    }
}
