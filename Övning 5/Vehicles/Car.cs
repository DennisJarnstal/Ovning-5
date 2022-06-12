using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5.Vehicles
{
    public class Car : vehiclesInGarage
    {
        public int Horsepower { get; set; }
        public override string ToString() => $"Bil - Antal häskrafter: {Horsepower}, " + base.ToString();
    }
}
