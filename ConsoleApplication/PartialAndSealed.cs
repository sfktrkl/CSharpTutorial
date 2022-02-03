
namespace ConsoleApplication
{
    // Partial
    public partial class Employee
    {
        public void DoWork() { }
    }

    public partial class Employee
    {
        public void GoToLunch() { }
    }

    // Sealed
    class X
    {
        protected virtual void F() { }
        protected virtual void F2() { }
    }

    class Y : X
    {
        sealed protected override void F() { }
        protected override void F2() { }
    }

    class Z : Y
    {
        // protected override void F() { }
        protected override void F2() { }
    }
}
