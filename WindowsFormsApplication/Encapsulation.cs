using OOP;

namespace WindowsFormsApplication
{
    // Derived class (different assembly)
    public class Encapsulation4 : Encapsulation
    {
        private void Method()
        {
            publicInt++;
            //privateInt++;
            //internalInt++;
            protectedInt++;
            //privateProtectedInt++;
            protectedInternalInt++;
        }
    }

    // Non-derived class (different assembly)
    public class Encapsulation5
    {
        private void Method()
        {
            var encapsulation = new Encapsulation();
            encapsulation.publicInt++;
            //encapsulation.privateInt++;
            //encapsulation.internalInt++;
            //encapsulation.protectedInt++;
            //encapsulation.privateProtectedInt++;
            //encapsulation.internalProtectedInt++;
        }
    }
}
