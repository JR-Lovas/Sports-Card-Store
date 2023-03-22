using System;
using System.Collections.Generic;
using System.Text;

namespace SportsCardStore
{
    public class Jersey : SportsItem
    {
        public string Team { get; set; }
        public int JerseyNumber { get; set; }

        public Jersey(string title, string team, int jerseyNumber, decimal price)
        {
            Title = title;
            Team = team;
            JerseyNumber = jerseyNumber;
            Price = price;
        }
        public override string ToString()
        {
            return $"Title: {Title}, Team: {Team}, JerseyNumber: {JerseyNumber}, Price: {Price}";
        }
    }
}
