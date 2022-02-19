using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication
{
    class FacadePattern
    {
        public interface IShape
        {
            public void Draw();
        }

        public class Rectangle : IShape
        {
            public void Draw()
            {
                Console.WriteLine("Rectangle");
            }
        }

        public class Square : IShape
        {
            public void Draw()
            {
                Console.WriteLine("Square");
            }
        }

        public class ShapeMaker
        {
            private readonly IShape rectangle;
            private readonly IShape square;

            public ShapeMaker()
            {
                rectangle = new Rectangle();
                square = new Square();
            }

            public void DrawRectangle()
            {
                rectangle.Draw();
            }

            public void DrawSquare()
            {
                square.Draw();
            }
        }
    }
}
