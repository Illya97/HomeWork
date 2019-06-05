using System;

namespace HomeWork4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte[] arr_sbyte = new sbyte[10];
            short[] arr_short = new short[10];
            int[] arr_int = new int[10];
            int flag_sbyte = 0;
            int flag_short = 0;
            int flag_int = 0;
            int count = 0;
            Random rnd = new Random();
            do
            {
                int rnd_Number = rnd.Next();
                if (flag_sbyte < 10 && rnd_Number <= sbyte.MaxValue)
                {
                    arr_sbyte[flag_sbyte++] = (sbyte)rnd_Number;
                }
                else if (flag_short < 10 && rnd_Number <= short.MaxValue)
                {
                    arr_short[flag_short++] = (short)rnd_Number; 
                }
                else if (flag_int < 10)
                {
                    arr_int[flag_int++] = rnd_Number;
                }
                count++;
            } while (flag_sbyte<10 || flag_short<10 || flag_int<10);
            for (int i = 0; i < arr_sbyte.Length; i++)
            {
                Console.Write(arr_sbyte[i]+" ");
            }
            Console.WriteLine("");
            for (int i = 0; i < arr_short.Length; i++)
            {
                Console.Write(arr_short[i] + " ");
            }
            Console.WriteLine("");
            for (int i = 0; i < arr_int.Length; i++)
            {
                Console.Write(arr_int[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine(count);
        }
    }
}
