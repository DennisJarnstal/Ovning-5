using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5
{
    public class vehiclesInGarage : EntityBase
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }

        public override string ToString() => $"Reg nummer; {Id}, Märke på fordon: {Name}, Fordonets färg: {Color}, Antal hjul: {NumberOfWheels}";
    }

}
