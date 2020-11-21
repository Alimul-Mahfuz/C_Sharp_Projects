using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{

    public abstract class Shape
    {
        public abstract double area();
        public abstract double perimeters();
    }

    public class Triangles : Shape
    {
        private double bases, height, s;

        public Triangles(double bases, double height, double s)
        {
            this.bases = bases;
            this.height = height;
            this.s = s;
        }

        public override double area()
        {
            double a;
            a = (bases * height) / 2;
            return a;
        }

        public override double perimeters()
        {
            double p = s + height + bases;
            return p;
        }

        public void Show()
        {
            Console.WriteLine("Area of Triangle : " + area());
            Console.WriteLine("Perimeters of Triangle : " + perimeters());
        }
    }

    public class Rectangles : Shape
    {
        private double length;
        private double breadth;

        public Rectangles(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public override double area()
        {
            double area = length * breadth;
            return area;
        }

        public override double perimeters()
        {
            double p = (2 * length) + (2 * breadth);
            return p;
        }

        public void Show()
        {
            Console.WriteLine("Rectangle of Area : " + area());
            Console.WriteLine("Rectangle of Perimeter : " + perimeters());
        }
    }

    public class Circles : Shape
    {
        private double radius;
        private double pi = 3.1416;

        public Circles(double radius)
        {
            this.radius = radius;
        }

        public override double area()
        {
            double area = pi * radius * radius;
            return area;
        }

        public override double perimeters()
        {
            double p = 2 * pi * radius;
            return p;
        }

        public void Show()
        {
            Console.WriteLine("Circle of Area : " + area());
            Console.WriteLine("Circle of Perimeters : " + perimeters());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Triangle");
            Console.WriteLine("2.Rectangle");
            Console.WriteLine("3.Circle");
            Console.WriteLine();
            Console.Write("Enter Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            char ch = 'Y';
            while (ch == 'Y')
            {
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("**********Triangle**********");
                            Console.WriteLine();
                            Console.Write("Enter the Base : ");
                            double bases = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the Height : ");
                            double height = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the  side : ");
                            double s = Convert.ToDouble(Console.ReadLine());
                            Triangles t = new Triangles(bases, height, s);
                            t.Show();
                        }
                        break;


                    case 2:
                        {
                            Console.WriteLine("**********Rectangle**********");
                            Console.WriteLine();
                            Console.Write("Enter the Lenght : ");
                            double length = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the Breadth : ");
                            double breadth = Convert.ToDouble(Console.ReadLine());
                            Rectangles r = new Rectangles(length, breadth);
                            r.Show();
                        }
                        break;

                    case 3:
                        {
                            Console.WriteLine("**********Circle**********");
                            Console.WriteLine();
                            Console.Write("Enter the Radius : ");
                            double radius = Convert.ToDouble(Console.ReadLine());
                            Circles c = new Circles(radius);
                            c.Show();
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Not given a valid choice.");
                        }
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Do you calculate again?(Y/N)");
                Console.WriteLine();
                ch = Console.ReadLine()[0];
            }
        }
    }
}
