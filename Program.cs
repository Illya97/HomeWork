using System;

namespace Home_Work5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] arr = new char[15][];
            for (int i = 0; i < arr.Length; i++)
            {
                char[] temp = new char[15];
                for (int j = 0; j < temp.Length; j++)
                {
                    if (i==0||i==arr.Length-1||j==0||j==temp.Length-1||(i==(arr.Length-1)/2&&j==(temp.Length-1)/2) || (i == (arr.Length - 1) / 2 && j == ((temp.Length - 1) / 2)+1) || (i == (arr.Length - 1) / 2 && j == ((temp.Length - 1) / 2) - 1) || (i == ((arr.Length - 1) / 2)+1 && j == (temp.Length - 1) / 2) || (i == ((arr.Length - 1) / 2)- 1 && j == (temp.Length - 1) / 2))
                    {
                        temp[j] = '*';
                    }else
                    {
                        temp[j] = ' '; 
                    }
                   
                }
                arr[i] = temp;
             
            }
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 0; j < arr[i].Length; j++)
                {

                    Console.Write(arr[i][j] + "");
                }

                Console.WriteLine("");
            }
        }
    }
}
