
namespace ConsoleApplication
{
    class OutClass
    {
        public static void OutClassMethod() { }

        protected class InClass
        {
            public static void InClassMethod() { }
        }
    }

    class NewClass : OutClass
    {
        public void NewClassMethod()
        {
            OutClassMethod();
            InClass.InClassMethod();
        }
    }

    class NewNewClass
    {
        public void NewNewClassMethod()
        {
            OutClass.OutClassMethod();
            //InClass.InClassMethod();
        }
    }
}
