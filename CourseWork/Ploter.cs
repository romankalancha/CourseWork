using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class Ploter
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Model { get; set; }
        public int CountColors { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
        public bool WinSupport { get; set; }
        public bool MacSupport { get; set; }

        public Ploter()
        {
        }

        public Ploter(string name, string country, string model, int countColors, int weight, int price, bool winSup, bool macSup)
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

    }
}

