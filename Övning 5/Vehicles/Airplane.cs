using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5.Vehicles
{
    public class Airplane : vehiclesInGarage
    {
        public int NumberOfSeats { get; set; }
        public override string ToString() => $"Flygplan - Antal stolar: {NumberOfSeats}, " + base.ToString();
    }
}
