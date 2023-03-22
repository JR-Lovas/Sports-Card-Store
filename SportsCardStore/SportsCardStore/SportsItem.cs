using System;
using System.Collections.Generic;
using System.Text;

namespace SportsCardStore
{
    public class SportsItem : IPurchasable
    {
        public string Title { get; set; }
        public decimal Price { get; set; }

    }
}
