using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class Equip
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Producer { get; set; }

        public Equip(){}

        public Equip(string name, int price, string producer)
        {
            Name = name;
            Price = price;
            Producer = producer;
        }
    }

    public class Keyboard : Equip
    {
        public int Width { get; set; }

        public Keyboard(){}

        public Keyboard(int width)
        {
            Width = width;
        }
    }
}

