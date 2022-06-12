using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5.Vehicles
{
    public class Motorcycle : vehiclesInGarage
    {
        public int NoOfPaintedFlames { get; set; }
        public override string ToString() => $"Motorcykel - Antal målade flames: {NoOfPaintedFlames}, " + base.ToString();
    }
}
