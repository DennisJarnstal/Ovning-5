using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5.FunctionsBase
{
    //Denna används ej, sattes upp som test för funktionen
    public static class InstancesFunctions
    {
        public static void AddBatch<T>(this IWriteGarage<T> GarageList, T[] items)
        {
            foreach (var item in items)
            {
                GarageList.Add(item);
            }
            GarageList.Save();
        }
    }
}
