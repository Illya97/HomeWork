using System;


namespace HomeWork3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Згенерировать число 
            Random rnd = new Random();
            int number = rnd.Next(0, 1000000);
          
            double number_double = number;
            //Определения количества цифр 
            int number_of_digits = 0;
            
            if (Math.Floor(number_double / 10) == 0)
            {
                number_of_digits = 1;
            }
            else if (Math.Floor(number_double / 100) == 0)
            {
                number_of_digits = 2;
            }
            else if (Math.Floor(number_double / 1000) == 0)
            {
                number_of_digits = 3;
            }
            else if (Math.Floor(number_double / 10000) == 0)
            {
                number_of_digits = 4;
            }
            else if (Math.Floor(number_double / 100000) == 0)
            {
                number_of_digits = 5;
            }
            else if (Math.Floor(number_double / 1000000) == 0)
            {
                number_of_digits = 6;
            }
            else if (number == 1000000)
            {
                number_of_digits = 7;
            }else if (number == 0)
            {
                number_of_digits = 0;
            }

            // Сума чисел кратних трьом, Количество  нечетних цифр 
            int first_digit =0;
            int second_digit=0;
            int third_digit=0;
            int fourth_digit=0;
            int fifth_digit=0;
            int sixth_digit=0;
            int sum = 0;
            int qnt_odd=0;
            if (number_of_digits == 1)
            {
                // Сума чисел кратних трьом
                first_digit = number;
                if (first_digit % 3 == 0)
                {
                    sum += first_digit;
                }
                //Количество  нечетних цифр
                if (first_digit % 2 != 0)
                {
                    qnt_odd++;
                }

            }
            else if (number_of_digits == 2)
            {
                first_digit = (int)Math.Floor(number_double / 10);
                second_digit = number % 10;
                // Сума чисел кратних трьом
                if (first_digit%3 == 0)
                {
                    sum += first_digit;
                }
                if (second_digit%3 == 0)
                {
                    sum += second_digit;
                }
                //Количество  нечетних цифр 
                if (first_digit % 2 != 0)
                {
                    qnt_odd++;
                }
                if (second_digit % 2 != 0)
                {
                    qnt_odd++;
                }
              

            }
            else if (number_of_digits == 3)
            {
                first_digit = (int)Math.Floor(number_double / 100);
                second_digit = ((int)Math.Floor(number_double / 10))%10;
                third_digit = number % 10;
                // Сума чисел кратних трьом
                if (first_digit%3 == 0)
                {
                    sum += first_digit;
                }
                if (second_digit%3 == 0)
                {
                    sum += second_digit;
                }
                if (third_digit%3 == 0)
                {
                    sum += third_digit;
                }
                //Количество  нечетних цифр 
                if (first_digit % 2 != 0)
                {
                    qnt_odd++;
                }
                if (second_digit % 2 != 0)
                {
                    qnt_odd++;
                }
                if (third_digit % 2 != 0)
                {
                    qnt_odd++;
                }
              
            }
            else if (number_of_digits == 4)
            {
                first_digit = (int)Math.Floor(number_double / 1000);
                second_digit = ((int)Math.Floor(number_double / 100)) % 10;
                third_digit = ((int)Math.Floor(number_double / 10)) % 10;
                fourth_digit = number % 10;
                // Сума чисел кратних трьом
                if (first_digit%3 == 0)
                {
                    sum += first_digit;
                }
                if (second_digit%3 == 0)
                {
                    sum += second_digit;
                }
                if (third_digit%3 == 0)
                {
                    sum += third_digit;
                }
                if (fourth_digit%3 == 0)
                {
                    sum += fourth_digit;
                }
                //Количество  нечетних цифр 
                if (first_digit % 2 != 0)
                {
                    qnt_odd++;
                }
                if (second_digit % 2 != 0)
                {
                    qnt_odd++;
                }
                if (third_digit % 2 != 0)
                {
                    qnt_odd++;
                }
                if (fourth_digit % 2 != 0)
                {
                    qnt_odd++;
                }
                
            }
            else if (number_of_digits == 5)
            {
                first_digit = (int)Math.Floor(number_double / 10000);
                second_digit = ((int)Math.Floor(number_double / 1000)) % 10;
                third_digit = ((int)Math.Floor(number_double / 100)) % 10;
                fourth_digit = ((int)Math.Floor(number_double / 10)) % 10;
                fifth_digit = number % 10;
                // Сума чисел кратних трьом
                if (first_digit%3 == 0)
                {
                    sum += first_digit;
                }
                if (second_digit%3 == 0)
                {
                    sum += second_digit;
                }
                if (third_digit%3 == 0)
                {
                    sum += third_digit;
                }
                if (fourth_digit%3 == 0)
                {
                    sum += fourth_digit;
                }
                if (fifth_digit%3 == 0)
                {
                    sum += fifth_digit;
                }
                //Количество  нечетних цифр 
                if (first_digit % 2 != 0)
                {
                    qnt_odd++;
                }
                if (second_digit % 2 != 0)
                {
                    qnt_odd++;
                }
                if (third_digit % 2 != 0)
                {
                    qnt_odd++;
                }
                if (fourth_digit % 2 != 0)
                {
                    qnt_odd++;
                }
                if (fifth_digit % 2 != 0)
                {
                    qnt_odd++;
                }
               
            }
            else if (number_of_digits == 6)
            {
                first_digit = (int)Math.Floor(number_double / 100000);
                second_digit = ((int)Math.Floor(number_double / 10000)) % 10;
                third_digit = ((int)Math.Floor(number_double / 1000)) % 10;
                fourth_digit = ((int)Math.Floor(number_double / 100)) % 10;
                fifth_digit = ((int)Math.Floor(number_double / 10)) % 10;
                sixth_digit = number % 10;
                // Сума чисел кратних трьом
                if (first_digit % 3 == 0)
                {
                    sum += first_digit;
                }
                if (second_digit % 3 == 0)
                {
                    sum += second_digit;
                }
                if (third_digit % 3 == 0)
                {
                    sum += third_digit;
                }
                if (fourth_digit % 3 == 0)
                {
                    sum += fourth_digit;
                }
                if (fifth_digit % 3 == 0)
                {
                    sum += fifth_digit;
                }
                if (sixth_digit % 3 == 0)
                {
                    sum += sixth_digit;
                }
                //Количество  нечетних цифр 
                if (first_digit %2!=0)
                {
                    qnt_odd++;
                }
                if (second_digit % 2 != 0)
                {
                    qnt_odd++;
                }
                if (third_digit % 2 != 0)
                {
                    qnt_odd++;
                }
                if (fourth_digit % 2 != 0)
                {
                    qnt_odd++;
                }
                if (fifth_digit % 2 != 0)
                {
                    qnt_odd++;
                }
                if (sixth_digit % 2 != 0)
                {
                    qnt_odd++;
                }
            }
            // Ввивод
            if (number_double == 0|| number_double == 7)
            {
                Console.WriteLine("Загаданое число: " + number_double + "; ");
            }else 
            {
                Console.WriteLine("Загаданое число: " + number_double + "; ");
                Console.WriteLine("Количество цифр в числе: " + number_of_digits + "; ");
                Console.WriteLine("Сума чисел кратних трьом: " + sum + "; ");
                Console.WriteLine("Количество нечетних цифр: " + qnt_odd + "; ");
            }
            
        }
    }
}
