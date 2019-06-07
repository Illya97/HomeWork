using System;

namespace HomeWork6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод данних
            Console.WriteLine("Enter last first Surname: ");
            string lastfirstsurname = Console.ReadLine(); 
            string tempString = "";
            Boolean Space = false;
            // Удаляем ненужные пробелы
            lastfirstsurname = lastfirstsurname.Trim();
            for (int i = 0; i < lastfirstsurname.Length; i++)
            {
                //если пробел..
                if (lastfirstsurname[i] == ' ')
                {
                    //если перед этим тоже был пробел..
                    if (Space)
                    {
                        //следующая итерация 
                        continue;
                        

                    }
                    else
                    {
                        //если перед этим пробелом небыло устанавливаем флаг первого пробела
                        Space = true;
                        tempString += lastfirstsurname[i];
                    }
                   
                }
                else
                {
                    //если символ не пробел то убираем флаг первого пробела
                    Space = false;
                    tempString += lastfirstsurname[i];
                }
            }
            lastfirstsurname = tempString;
            tempString = "";
            Console.WriteLine(tempString);
            //Розбивка на слова 
            string[] words = lastfirstsurname.Split(new char[] { ' ' });
            lastfirstsurname = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (i==0)
                {
                    for (int j = 0; j < words[0].Length; j++)
                    {
                        if (j==0)
                        {
                            tempString += words[i][j].ToString().ToUpper();
                        }
                        else
                        {
                            tempString += words[i][j];
                        }
                    }
                    words[i] = tempString;
                }
                else if (i == 1)
                {
                    words[1] = words[1].ToUpper().Remove(1,words[1].Length-1);
                    words[1] = words[1] + '.';
                   
                }
                else if (i == 2)
                {
                    words[2] = words[2].Remove(1, words[2].Length-1).ToUpper();
                    words[2]=words[2] + '.';
                   
                }
                lastfirstsurname += words[i]+" ";
            }
            Console.WriteLine(lastfirstsurname);
        }
    }
}
