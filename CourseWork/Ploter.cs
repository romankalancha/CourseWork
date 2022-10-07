using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public enum TownsSortOrder
    {
        SortByName = 1, SortByCountry = 2, SortByCountColors = 3,
        SortByWeight = 4, SortByPrice = 5
    };

    public class Ploter : IComparable
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Model { get; set; }
        public int CountColors { get; set; }
        public int Weight { get; set; }
        public double Price { get; set; }
        public bool WinSupport { get; set; }
        public bool MacSupport { get; set; }


        public TownsSortOrder SortOrder { get; set; }

        public Ploter()
        {
        }

        public Ploter(string name, string country, string model, int countColors, int weight, double price, bool winSup, bool macSup)
        {
            Name = name; 
            Country = country;
            Model = model;
            CountColors = countColors;
            Weight = weight;
            Price = price;
            WinSupport = winSup;
            MacSupport = macSup;
        }
        public string GeneralInfo()
        {
            return Name + ", " + Model + ", " + Country;
        }

        public int CompareTo(object obj)
        {
            Ploter p = obj as Ploter; switch (this.SortOrder)
            {
                case TownsSortOrder.SortByName:
                    return string.Compare(this.Name, p.Name);
                case TownsSortOrder.SortByCountry:
                    return string.Compare(this.Country, p.Country);
                case TownsSortOrder.SortByCountColors:
                    return (this.CountColors > p.CountColors ? 1 : (this.CountColors < p.CountColors ? -1 : 0));
                case TownsSortOrder.SortByWeight:
                    return (this.Weight > p.Weight ? 1 : (this.Weight < p.Weight ?
                    -1 : 0));
                case TownsSortOrder.SortByPrice:
                    return (this.Price > p.Price ? 1 : (this.Price < p.Price ? -1 : 0));
                default:
                    return string.Compare(this.Name, p.Name);
            }

        }


    }

}
