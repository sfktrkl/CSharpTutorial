
namespace ConsoleApplication
{
    // Compile time polymorphism
    class Calculator
    {
        public int Add(int a, int b, int c) { return a + b + c; }
        public int Add(int a, int b) { return a + b; }
    }

    // Run time polymorphism
    public class Drawing
    {
        public virtual double Area() { return 0; }
    }

    public class Circle : Drawing
    {
        private double radius = 5;
        public override double Area() { return 3.14 * radius * radius; }
    }

    public class Square : Drawing
    {
        private double length = 5;
        public override double Area() { return length * length; }
    }

    public class Rectangle : Drawing
    {
        private double height = 5;
        private double width = 5;
        public override double Area() { return height * width; }
    }
}
