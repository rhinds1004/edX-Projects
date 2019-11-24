using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOMod1
{
    class DrinksMachine
    {
        public DrinksMachine(string loc, string make, string model)
        {
            Location = loc;
            Make = make;
            Model = model;
        }

        private string _location;
        private string _make;
        private string _model;

        public string Location { get => _location; set => _location = value; }
        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }

        public void MakeCappuccino()
        {
            Console.WriteLine("Cappuccino is made.");
        }
    }
}
