using System;

namespace HomeWork4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr= { 2,2,6,4,4,98,2,2,3,1,1,1,1};
            int temp = 0;
            Boolean flag = false;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 1; j < arr.Length-i; j++)
                {
                    flag = false; 
                    if (arr[j-1] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[j-1];
                        arr[j-1] = temp;
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    break;
                } 
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("b[" + i + "] = " + arr[i]);
            }
        }
    }
}
