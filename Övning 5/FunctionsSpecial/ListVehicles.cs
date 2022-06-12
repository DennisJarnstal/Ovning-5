using Övning_5.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5.FunctionsSpecial
{
    public class ListVehicles
    {
        public void WriteAllToConsole(IReadGarage<IEntity> GarageList)
        {
            Console.WriteLine("Vänligen se nedan lista på samtliga fordon i garaget:");
            var items = GarageList.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public void WriteVehiclesToConsole(IReadGarage<vehiclesInGarage> vehicleInGarageList)
        {
            int countVehiclesInGarage = 0;
            var items = vehicleInGarageList.GetAll();
            foreach (var item in items)
            {
                countVehiclesInGarage++;
            }
            Console.WriteLine("Antal fordon: " + countVehiclesInGarage.ToString());
        }
        public void WriteAirplaneToConsole(IReadGarage<Airplane> airplanesInGarageList)
        {
            int countVehiclesInGarage = 0;
            var items = airplanesInGarageList.GetAll();
            foreach (var item in items)
            {
                countVehiclesInGarage++;
            }
            Console.WriteLine("Antal flygplan: " + countVehiclesInGarage.ToString());
        }
        public void WriteBoatToConsole(IReadGarage<Boat> boatsInGarageList)
        {
            int countVehiclesInGarage = 0;
            var items = boatsInGarageList.GetAll();
            foreach (var item in items)
            {
                countVehiclesInGarage++;
            }
            Console.WriteLine("Antal båtar: " + countVehiclesInGarage.ToString());
        }
        public void WriteBusToConsole(IReadGarage<Bus> bussesInGarageList)
        {
            int countVehiclesInGarage = 0;
            var items = bussesInGarageList.GetAll();
            foreach (var item in items)
            {
                countVehiclesInGarage++;
            }
            Console.WriteLine("Antal bussar: " + countVehiclesInGarage.ToString());
        }
        public void WriteCarToConsole(IReadGarage<Car> carsInGarageList)
        {
            int countVehiclesInGarage = 0;
            var items = carsInGarageList.GetAll();
            foreach (var item in items)
            {
                countVehiclesInGarage++;
            }
            Console.WriteLine("Antal bilar: " + countVehiclesInGarage.ToString());
        }
        public void WriteMotorcycleToConsole(IReadGarage<Motorcycle> motorcyclesInGarageList)
        {
            int countVehiclesInGarage = 0;
            var items = motorcyclesInGarageList.GetAll();
            foreach (var item in items)
            {
                countVehiclesInGarage++;
            }
            Console.WriteLine("Antal motorcyklar: " + countVehiclesInGarage.ToString());
        }
        public void GetVehicleById(ISqlGarage<vehiclesInGarage> vehicleInGarageList)
        {
            string regEntered = Console.ReadLine();
            var vehicle = vehicleInGarageList.GetById(regEntered);
            Console.WriteLine($"Fordon med reg nummer {regEntered} - Märke: {vehicle.Name}, Färg: {vehicle.Color}, Antal hjul: {vehicle.NumberOfWheels}");
        }
    }

}
