using System;

namespace shapes
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SURFACE AREA OF SHAPES");
            Console.WriteLine("-----------------------");
            Console.Write("Please Input shape name: ");
             string shape = Console.ReadLine().ToUpper();
             string[] diffShapes = {"RECTANGLE", "TRIANGLE", "CIRCLE"};
             switch (shape)
             {
                case "RECTANGLE":
                  Console.WriteLine(diffShapes[0]);
                  Rectangle rect = new Rectangle();
                  Console.WriteLine("SURFACE AREA OF Rectangle is " + rect.CalculateSurface());
                    break;
                case "TRIANGLE":
                Console.WriteLine(diffShapes[1]);
                  Triangle tri = new Triangle();
                  Console.WriteLine("SURFACE AREA OF Triangle is " + tri.CalculateSurface());
                    break;
                     case "CIRCLE":
                     Console.WriteLine(diffShapes[2]);
                  Circle cir = new Circle();
                  Console.WriteLine("SURFACE AREA OF Circle is " + cir.CalculateSurface());
                    break;
                default:
                Console.WriteLine("You didnt input a shape from the list");
                break;
             }
             
        }
     }
     public abstract class Shape{
        //An abstract method
        abstract public double CalculateSurface();
                //field definition
    public double  height;
     public double  width;
       
        // Console.WriteLine(area);
        
    }
    public class Rectangle : Shape{
         double area;
        public override double CalculateSurface(){
              Console.Write("Input height: ");
             height = double.Parse(Console.ReadLine());
         Console.Write("Input width: ");
             width = double.Parse(Console.ReadLine());
             
         area = height*width;
        return area;
        }
    }
       public class Triangle : Shape{
         double area;
        public override double CalculateSurface(){
              Console.Write("Input height: ");
             height = double.Parse(Console.ReadLine());
         Console.Write("Input width: ");
             width = double.Parse(Console.ReadLine());
             
         area = height*width/2;
        return area;
        }
    }
      public class Circle : Shape{
         double area;
         double radius;
         private const double PI = 3.141592653589793;
         public Circle(){
            radius = height;
            radius = width;
         }
        public override double CalculateSurface(){
              Console.Write("Input radius: ");
             radius = double.Parse(Console.ReadLine());
             
         area = radius*radius*PI;
        return area;
        }
    }
  
}