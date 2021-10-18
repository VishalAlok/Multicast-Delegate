using System;

namespace Delegate
{
    //For Multicast deligates, they have have same signature and all are returning void 
    //if they return anything, we will get reponse from last method only
    public delegate void AreaDelegate(double x, double y);
    public delegate void PerimeterDelegate(double s, double t);
    class Rectangle
    {
        public void GetArea(double width, double height)
        {
            Console.WriteLine("Area of rectangle" + width * height);
        }
        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine("Perimeter of rectangle" + 2 *(width + height));
        }
        static void Main(string[] args)
        {
            Rectangle p = new Rectangle();
            AreaDelegate obj = new AreaDelegate(p.GetArea);
            obj += p.GetPerimeter;
            obj.Invoke(12, 43);


        }
    }
}
