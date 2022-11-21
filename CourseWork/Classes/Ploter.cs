namespace CourseWork.Classes
{
    public class Ploter
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Model { get; set; }
        public int CountColors { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
        public bool WinSupport { get; set; }
        public bool MacSupport { get; set; }

        public Ploter()
        {
        }

        public Ploter(string name, string company, string model, int countColors, int weight, int price, bool winSup, bool macSup)
        {
            Name = name;
            Company = company;
            Model = model;
            CountColors = countColors;
            Weight = weight;
            Price = price;
            WinSupport = winSup;
            MacSupport = macSup;
        }
    }
}

