using System;

namespace HomeWork5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[12];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 30 + ((i + 1) + ((i + 1) / 8)) % 2;
                Console.WriteLine(i+1 +" month - "+arr[i]);
            }
        }
    }
}
