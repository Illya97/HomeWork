using System;

namespace HomeWork4_3
{
    class Program
    {
        static void Main(string[] args)
        {/*
            char[] arr = new char[10];
            arr[0] = '@';
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = '_';
            }
            */
            //----------------------------------------
            Boolean finish = true;
            char temp = ' ';
            int hp = 50;
            /*
            // Генерация рандомного '*' '+'
            Random rnd = new Random();
            int rnd_mines = rnd.Next(1,arr.Length-2);
            arr[rnd_mines] ='*';
           
            int rnd_heal = rnd.Next(1, arr.Length - 2);
            arr[rnd_heal] = '+';
           

            do
            {
                int rnd_heal = rnd.Next(1, arr.Length - 2);
                if (rnd_heal != rnd_mines)
                {
                    arr[rnd_heal] = '+';
                }
                else
                {
                    rnd_heal = rnd.Next(1,arr.Length - 2);
                    arr[rnd_heal] = '+';
                    finish = false;
                }
                
            } while (finish==false);

    */
            finish = true;
            //test
            char[] arr = {'@','+','*','_','_','_','_','_','_','_'};
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
                Console.WriteLine("0123456789");
                Console.WriteLine("Введите действие: a - движение влево, d - движение вправо.");

                string run = Console.ReadLine();
                if (run == "a" && arr[0]!='@')
                {
                    temp = arr[0];
                    for (int i = 0; i < arr.Length-1; i++)
                    {
                        if ((arr[i+1] == '*' && arr[i +2] == '@'))
                        {
                            arr[i + 1] = '@';
                            arr[i - 2] = '_';
                            hp -= 40;
                            i += 2;
                            continue;
                        }
                        else if ((arr[i+1] == '+' && arr[i +2] == '@'))
                        {

                            arr[i +1] = '@';
                            arr[i +2] = '_';
                            hp += 40;
                            i += 2;
                            continue;
                        }
                        else if ((arr[i + 1] == '*' && arr[i + 2] != '+') || (arr[i + 1] == '+' && arr[i + 2] != '*'))
                        {
                            arr[i] = arr[i + 2];
                            i++;
                            continue;
                        }
                        else if ((arr[i + 1] == '*' && arr[i + 2] == '+') || (arr[i + 1] == '+' && arr[i + 2] == '*'))
                        {
                            arr[i] = arr[i + 3];
                            i+= 2;
                            continue;
                        }
                        
                        arr[i] = arr[i + 1];
                    }
                    arr[arr.Length - 1] = temp;
                    hp -= 5;
                }else if (run == "d")
                {
                    temp = arr[arr.Length-1];
                    for (int i = arr.Length - 1; i >0; i--)
                    {/*
                        if (arr[i - 1] == '*' && arr[i - 2] == '+' && arr[i - 3] == '@')
                        {
                            arr[i - 2] = arr[i - 3];
                            arr[i - 3] = '_';
                            hp += 40;
                            Console.WriteLine(i + "  1");
                            i++;
                           
                           
                        }
                        else if (arr[i - 1] == '+' && arr[i - 2] == '*' && arr[i - 3] == '@')
                        {
                            arr[i - 2] = arr[i - 3];
                            arr[i - 3] = '_';
                            hp -= 40;
                            Console.WriteLine(i + "  2");
                            i++;
                            
                          
                        }
                       else if (arr[i - 1] == '*' && arr[i - 2] != '+'&& arr[i - 3] != '@')
                        {
                            arr[i] = arr[i - 2];
                            Console.WriteLine(i + "  3");
                            i--;
                            
                        }
                       else if (arr[i - 1] == '+' && arr[i - 2] != '*' && arr[i - 3] != '@')
                        {
                            arr[i] = arr[i - 2];
                            Console.WriteLine(i + "  3.1");
                            i--;

                          
                        }
                        else if ((arr[i - 1] == '*' && arr[i - 2] == '@'))
                        {
                            arr[i - 1] = '@';
                            arr[i - 2] = '_';
                            hp -= 40;
                            Console.WriteLine(i + "  4");
                            i --;
                         
                            
                        }
                        else if ((arr[i - 1] == '+' && arr[i - 2] == '@'))
                        {

                            arr[i - 1] = '@';
                            arr[i - 2] = '_';
                            hp += 40;
                            Console.WriteLine(i + "  5");
                            i --;
                           
                            
                        }
                        else if ((arr[i - 1] == '*' && arr[i - 2] == '+') || (arr[i - 1] == '+' && arr[i - 2] == '*'))
                        {
                            arr[i] = arr[i - 3];
                            Console.WriteLine(i + "  6");
                            i -= 2;
                    
                        }
                        else
                        {
                            arr[i] = arr[i - 1];
                            Console.WriteLine(i + "  1");
                        }
                        */
                        arr[i] = arr[i - 1];
                    }
                    arr[0] = temp;
                    hp -= 5;
                }
                    
            } while (finish && hp>0);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "");
            }
            Console.WriteLine("");
            Console.WriteLine("Game Over");
        }
    }
}
