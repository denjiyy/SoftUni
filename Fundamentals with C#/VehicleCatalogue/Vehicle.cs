using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleCatalogue
{
    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; private set; }
        public string Model { get; private set; }
        public string Color { get; private set; }
        public int HorsePower { get; private set; }

        public override string ToString()
        {
            return $"Type: {Type}\nModel: {Model}\nColor: {Color}\nHorsepower: {HorsePower}";
        }
    }
}
