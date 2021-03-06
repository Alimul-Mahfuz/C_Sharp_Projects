﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Name: Alimul Mahfuz Tushar, ID: 19-39831-1, Section: M

namespace ConsoleApplication_Lab_Task_Mid
{
    //Abastract Class Shape
    public abstract class Shape  //abastract class contain two abastract methods
    {
        public abstract void area();
        public abstract void perimeters();
    }

    //Class Circle
    class Circle : Shape   //Inherited calss Cricle
    {
        private const double pi = 3.1416;
        private double r;
        public Circle(double r)
        {
            this.r = r;
            area();
            perimeters();
        }
        public override void area()
        {
            double area;
            area = pi * r * r;
            Console.WriteLine("Area Of Circle: " + Math.Round(area, 3) + " sq unit");
        }
        public override void perimeters()
        {
            double perimeter;
            perimeter = 2 * pi * r;
            Console.WriteLine("Perimeter of Circle " + Math.Round(perimeter, 3) + " unit");
        }
    }

    //Class Circle
    public class Triangle : Shape
    {
        private double bases;
        private double height;
        private double a, b;

        public Triangle(double bases, double height, double a, double b)
        {
            this.bases = bases;
            this.height = height;
            this.a = a;
            this.b = b;
            area();
            perimeters();
        }

        public override void area()  //Overriden method area
        {
            double area;
            area = 0.5 * bases * height;
            Console.WriteLine("Area of Triangle: " + Math.Round(area, 3) + " sq unit"); //For rounding upto two digits

        }

        public override void perimeters()  //Overriden method perimeters
        {
            double peri;
            peri = a + b + bases;
            Console.WriteLine("Perimeter of Triangle: " + Math.Round(peri, 3) + " sq unit");
        }
    }
    public class Rectangles : Shape
    {
        private double height;
        private double breadth;

        public Rectangles(double height, double breadth)
        {
            this.height = height;
            this.breadth = breadth;
            area();
            perimeters();
        }

        public override void area()
        {
            double area;
            area = height * breadth;
            Console.WriteLine("Area of Retangles: " + Math.Round(area, 3) + " sq unit");
        }
        public override void perimeters()
        {
            double peri;
            peri = 2 * height + 2 * breadth;
            Console.WriteLine("Perimeter of Rectangles" + Math.Round(peri, 3) + " unit");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            char chd;
            do
            {
                Console.WriteLine("1. Triangles");
                Console.WriteLine("2. Rectangles");
                Console.WriteLine("3. Circles");
                Console.WriteLine();
                Console.WriteLine("Enter Choice: ");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Base: ");
                            double bases = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Height: ");
                            double height = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter other two side of Triganle: ");
                            double a = Convert.ToDouble(Console.ReadLine());
                            double b = Convert.ToDouble(Console.ReadLine());
                            Triangle obj = new Triangle(bases, height, a, b);

                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter Height: ");
                            double height = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Width: ");
                            double width = Convert.ToDouble(Console.ReadLine());
                            Rectangles rect = new Rectangles(height, width);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter Radius: ");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            Circle cir = new Circle(radius);

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("No valid choice entered"); //For no valid input
                        }
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Do you Calculate again (Y/N)");
                chd = Console.ReadLine()[0];
            } while (chd == 'Y' || chd == 'y');
            Console.ReadKey();


        }
    }
}
