
namespace OOP
{
    // Within the class
    public class Encapsulation
    {
        public int publicInt;
        private int privateInt;
        internal int internalInt;
        protected int protectedInt;
        private protected int privateProtectedInt;
        protected internal int protectedInternalInt;

        private void Method()
        {
            // Has access to all.
            publicInt++;
            privateInt++;
            internalInt++;
            protectedInt++;
            privateProtectedInt++;
            protectedInternalInt++;
        }
    }

    // Derived class (same assembly)
    public class Encapsulation2 : Encapsulation
    {
        private void Method()
        {
            publicInt++;
            //privateInt++;
            internalInt++;
            protectedInt++;
            privateProtectedInt++;
            protectedInternalInt++;
        }
    }

    // Non-derived class (same assembly)
    public class Encapsulation3
    {
        private void Method()
        {
            var encapsulation = new Encapsulation();
            encapsulation.publicInt++;
            //encapsulation.privateInt++;
            encapsulation.internalInt++;
            //encapsulation.protectedInt++;
            //encapsulation.privateProtectedInt++;
            encapsulation.protectedInternalInt++;
        }
    }
}
