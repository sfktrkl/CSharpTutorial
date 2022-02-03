using System;

namespace ConsoleApplication
{
    // Abstract class
    abstract class Base
    {
        protected int _x = 100;
        protected int _y = 150;
        // Abstract method
        public abstract void AbstractMethod();
        // Abstract properties
        public abstract int X { get; }
        public abstract int Y { get; }
    }

    class Derived : Base
    {
        public override void AbstractMethod() { _x++; _y++; }
        public override int X { get { return _x + 10; } } // overriding property
        public override int Y { get { return _y + 10; } }  // overriding property
    }
}
