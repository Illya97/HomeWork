using System;

namespace HomeWork_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            int rnd_word = rnd.Next(3,8);
            int rnd_letter = rnd.Next(5,10);
            string[] arr_words= new string[rnd_word];
            string tempString = "";
            for (int i = 0; i < arr_words.Length; i++)
            {
                for (int j = 0; j < rnd_letter; j++)
                {
                    tempString += chars[rnd.Next(chars.Length)];
                }
                arr_words[i] = tempString;
                tempString += " ";
            }
       
            string arr_consonant = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
            int count = 0;
            for (int i = 0; i < tempString.Length; i++)
            {
                for (int j = 0; j < arr_consonant.Length; j++)
                {
                    if (tempString[i] == arr_consonant[j])
                    {
                        count++;
                    }
                }
               
            }
            Console.WriteLine("Рандомная строка слов: \n"+tempString+ "\nСогласные буквы в алфавите:\n"+ arr_consonant+ "\nколичество согласних слов:"+count);



        }
    }
}
