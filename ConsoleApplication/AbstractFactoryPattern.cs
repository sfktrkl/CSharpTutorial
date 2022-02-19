
namespace ConsoleApplication
{
    public class AbstractFactoryPattern
    {
        public abstract class Burger { }
        public abstract class Dessert { }

        public abstract class RecipeFactory
        {
            public abstract Burger CreateBurger();
            public abstract Dessert CreateDessert();
        }

        class SteakBurger : Burger { }
        class CreamBluer : Dessert { }
        public class AdultCuisineFactory : RecipeFactory
        {
            public override Burger CreateBurger()
            {
                return new SteakBurger();
            }

            public override Dessert CreateDessert()
            {
                return new CreamBluer();
            }
        }

        class KidBurger : Burger { }
        class IceCreaam : Dessert { }
        public class KidCuisineFactory : RecipeFactory
        {
            public override Burger CreateBurger()
            {
                return new KidBurger();
            }

            public override Dessert CreateDessert()
            {
                return new IceCreaam();
            }
        }
    }
}
