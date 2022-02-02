
namespace ConsoleApplication
{
    class BaseClass
    {
        // BaseClass
    }

    class SingleInheritance : BaseClass
    {
        //    BaseClass
        //        |
        // SingleInheritance 
    }

    class MultilevelInheritance : SingleInheritance
    {
        //      BaseClass
        //          |
        //   SingleInheritance 
        //          |
        // MultilevelInheritance 
    }

    class HierarchicalInheritance : BaseClass
    {
        //                  BaseClass
        //                  |       |
        //   SingleInheritance     HierarchicalInheritance
        //          |
        // MultilevelInheritance 
    }
}
