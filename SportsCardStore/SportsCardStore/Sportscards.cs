using System;
using System.Collections.Generic;
using System.Text;

namespace SportsCardStore
{
    public class Sportscards : SportsItem
    {
        public string Sport { get; set; }
        public Sportscards()
        {

        }

        public Sportscards(string title, string sport, decimal price)
        {
            this.Title = title;
            this.Sport = sport;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Title: {this.Title}, Sport: {this.Sport}, Price: ${this.Price}";
        }
    }
}
