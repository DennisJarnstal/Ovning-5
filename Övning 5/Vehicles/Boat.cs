using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5.Vehicles
{
    public class Boat : vehiclesInGarage
    {
        public int LengthInM { get; set; }
        public override string ToString() => $"Båt: Längd i m: {LengthInM}, " + base.ToString();
    }
}
