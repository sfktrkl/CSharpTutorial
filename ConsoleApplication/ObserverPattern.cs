using System.Collections.Generic;
using System;

namespace ConsoleApplication
{
    public class ObserverPattern
    {
        public interface IMarket
        {
            void Update(Product product);
        }

        public abstract class Product
        {
            private double price;
            List<IMarket> Markets = new List<IMarket>();

            public Product(double price)
            {
                this.price = price;
            }

            public void Attach(IMarket market)
            {
                Markets.Add(market);
            }

            public void Detach(IMarket market)
            {
                Markets.Remove(market);
            }

            public void Notify()
            {
                foreach (IMarket market in Markets)
                    market.Update(this);
                Console.WriteLine("");
            }

            public double PricePerPound
            {
                get { return price; }
                set
                {
                    if (price != value)
                        price = value;
                    Notify();
                }
            }
        }

        public class Chocolate : Product
        {
            public Chocolate(double price) : base(price) { }
        }

        public class Market : IMarket
        {
            private string name;
            private double price;

            public Market(string name, double price)
            {
                this.name = name;
                this.price = price;
            }

            public void Update(Product product)
            {
                Console.WriteLine(name + ": " + price.ToString() + " to " +
                                  product.GetType().Name + ": " + product.PricePerPound);
                this.price = product.PricePerPound;
            }
        }
    }
}
