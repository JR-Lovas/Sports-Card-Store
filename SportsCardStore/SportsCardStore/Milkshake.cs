using System;
using System.Collections.Generic;
using System.Text;

namespace SportsCardStore
{
    public class Milkshake : IPurchasable
    {
        public string Size { get; set; }
        public string Flavor { get; set; }
        public List<string> Toppings { get; private set; } = new List<string>();
        public decimal Price { get; set; }

        public Milkshake(string size, string flavor, string[] toppings, decimal price)
        {
            Size = size;
            Flavor = flavor;
            Toppings.AddRange(toppings);
            Price = price;
        }

        public void Add(string topping)
        {
            Toppings.Add(topping);
        }

        public override string ToString()
        {
            return $"{Size} milkshake, {Flavor} ({string.Join(", ", Toppings)}). Price: ${Price}";
        }
    }
}
