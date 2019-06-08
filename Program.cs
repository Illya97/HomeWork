using System;

namespace HomeWork7
{
   
    class Circle
    {
        
        private string color;
        private string name;
        private double perimeter;
        private double area;
        private const double pi = 3.14159265358979;
        private string[] arrcolor = {"red", "orange","yellow","green","purple","blue","black","white","silver","olive" }; 

        public void set(double radius)
        {
            Random rnd = new Random();
            color = arrcolor[rnd.Next(9)];
            name = "Circle";
            perimeter = 2*pi*radius;
            area = radius * radius;
        }

        public void getInf()
        {
            Console.Write("You change 1,this is circle.Please enter radius: ");
            set(double.Parse(Console.ReadLine()));
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Perimeter: " + perimeter);
            Console.WriteLine("Area: " + area);
        }

    }

    class Square
    {
        private string color;
        private string name;
        private double perimeter;
        private double area;
        private string[] arrcolor = { "red", "orange", "yellow", "green", "purple", "blue", "black", "white", "silver", "olive" };

        public void set(double side)
        {
            Random rnd = new Random();
            color = arrcolor[rnd.Next(9)];
            name = "Square";
            perimeter =4*side;
            area = side*side;
        }

        public void getInf()
        {
            Console.Write("You change 2,this is square.Please enter side: ");
            set(double.Parse(Console.ReadLine()));
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Perimeter: " + perimeter);
            Console.WriteLine("Area: " + area);
        }

    }
    class Triangle
    {
        private string color;
        private string name;
        private double perimeter;
        private double area;
        private string[] arrcolor = { "red", "orange", "yellow", "green", "purple", "blue", "black", "white", "silver", "olive" };

        public void set(double side, double height)
        {
            Random rnd = new Random();
            color = arrcolor[rnd.Next(9)];
            name = "Triangle";
            perimeter =side*3;
            area = (side * height) / 2;
        }

        public void getInf()
        {
            Console.Write("You change 1,this is triangle.Please enter side and height: ");
            set(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Perimeter: " + perimeter);
            Console.WriteLine("Area: " + area);
        }
    }
   
        
   
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Square square = new Square();
            Triangle triangle = new Triangle();
          
            do
            {
                Boolean end1=true;
                Console.WriteLine("Circle - enter 1; Square - enter 2 ;Triangle - enter 3; Exit - enter 0. ");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1": circle.getInf();break;
                    case "2": square.getInf();break;
                    case "3": triangle.getInf(); break;
                    case "0":end1=false; break;
                    default:end1 = false; ;
                        break;
                }

            } while (end1);
           
        }
    }
}
