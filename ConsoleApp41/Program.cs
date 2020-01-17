using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            int wybor;
            double a, b, w;
            do { 
            Console.WriteLine("For rectangle, press 1");
            Console.WriteLine("For square, press 2");
            Console.WriteLine("For triangle, press 3");
            Console.WriteLine("To exit, press 0");
            wybor = Convert.ToInt16(Console.ReadLine());
                switch (wybor)
                {
                    case 0: break;
                    case 1:
                        Console.Write("a= ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("b= ");
                        b = Convert.ToDouble(Console.ReadLine());
                        w = a * b; Console.WriteLine("Area of that rectangle is {0}", w);
                        break;
                    case 2:
                        Console.Write("a= ");
                        a = Convert.ToDouble(Console.ReadLine());
                        w = a * a; Console.WriteLine("Area of that square is equal to {0}", w);
                        break;
                    case 3:
                        Console.Write("a= ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("b= ");
                        b = Convert.ToDouble(Console.ReadLine());
                        w = (a * b) / 2; Console.WriteLine("Area of that triangle is equal to {0}", w);
                        break;
                    default:
                        Console.WriteLine("Error, try again.");
                        break;
                }
                }while (wybor != 0) ;
        }
    }
}
