using Övning_5.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5.FunctionsSpecial
{
    public class AddVehicles
    {
        public string regNo;
        public string name;
        public string color;
        public int noOfWheels;
        public int noOfSeats;
        public int lengthInM;
        public int numberOfDents;
        public int horsepower;
        public int noOfPaintedFlames;

        public void AddVehiclesTest(ISqlGarage<vehiclesInGarage> vehicleInGarageList)
        {
            Console.WriteLine("Vänligen bekräfta att du önskar skapa en grupp med testfordon:");
            vehicleInGarageList.Add(new Airplane { Id = "ABC123", Name = "Cessna", Color = "Svart", NumberOfWheels = 3, NumberOfSeats = 14});
            vehicleInGarageList.Add(new Boat { Id = "ABC234", Name = "Träbåt", Color = "Brun", NumberOfWheels = 0, LengthInM = 3});
            vehicleInGarageList.Add(new Bus { Id = "ABC567", Name = "Sl buss", Color = "Röd", NumberOfWheels = 24, NumberOfDents = 14 });
            vehicleInGarageList.Add(new Car { Id = "ABC890", Name = "Volvo", Color = "Blå", NumberOfWheels = 24, Horsepower = 90 });
            vehicleInGarageList.Add(new Motorcycle { Id = "BED123", Name = "Harley", Color = "Svart", NumberOfWheels = 2, NoOfPaintedFlames = 6 });
            vehicleInGarageList.Add(new Airplane { Id = "BED234", Name = "Boeing", Color = "White", NumberOfWheels = 12, NumberOfSeats = 540 });
            vehicleInGarageList.Add(new Boat { Id = "BED567", Name = "Silja Line", Color = "Vit", NumberOfWheels = 3, LengthInM = 500});
            vehicleInGarageList.Add(new Bus { Id = "BED890", Name = "Stor rackare", Color = "Yellow", NumberOfWheels = 60, NumberOfDents = 54 });
            vehicleInGarageList.Save();
        }

        public void AddAirplaneToList2(ISqlGarage<Airplane> airplaneInGarageList)
        {
            AddVehicleFunction();
            try
            {
                Console.WriteLine("Skriv in antal sittplatser:");
                noOfSeats = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            airplaneInGarageList.Add(new Airplane { Id = regNo, Name = name, Color = color, NumberOfWheels = noOfWheels, NumberOfSeats = noOfSeats });
            airplaneInGarageList.Save();

        }
        public void AddBoatToList2(ISqlGarage<Boat> boatsInGarageList)
        {
            AddVehicleFunction();
            try
            {
                Console.WriteLine("Skriv in längd i meter:");
                lengthInM = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            boatsInGarageList.Add(new Boat { Id = regNo, Name = name, Color = color, NumberOfWheels = noOfWheels, LengthInM = lengthInM });
            boatsInGarageList.Save();

        }
        public void AddBusToList2(ISqlGarage<Bus> bussesInGarageList)
        {
            AddVehicleFunction();
            try
            {
                Console.WriteLine("Skriv in antal bucklor:");
                numberOfDents = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            bussesInGarageList.Add(new Bus { Id = regNo, Name = name, Color = color, NumberOfWheels = noOfWheels, NumberOfDents = numberOfDents });
            bussesInGarageList.Save();

        }
        public void AddCarToList2(ISqlGarage<Car> carsInGarageList)
        {
            AddVehicleFunction();
            try
            {
                Console.WriteLine("Skriv in hur många hästkrafter:");
                horsepower = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            carsInGarageList.Add(new Car { Id = regNo, Name = name, Color = color, NumberOfWheels = noOfWheels, Horsepower = horsepower });
            carsInGarageList.Save();

        }
        public void AddMotorcycleToList2(ISqlGarage<Motorcycle> motorcyclesInGarageList)
        {
            AddVehicleFunction();
            try
            {
                Console.WriteLine("Skriv in antal målade flamor:");
                noOfPaintedFlames = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            motorcyclesInGarageList.Add(new Motorcycle { Id = regNo, Name = name, Color = color, NumberOfWheels = noOfWheels, NoOfPaintedFlames = noOfPaintedFlames });
            motorcyclesInGarageList.Save();

        }


        public void AddVehicleFunction()
        {
            try
            {
                Console.WriteLine("Skriv in reg nummer:");
                regNo = Console.ReadLine();
                Console.WriteLine("Skriv in märke:");
                name = Console.ReadLine();
                Console.WriteLine("Skriv in färg:");
                color = Console.ReadLine();
                Console.WriteLine("Skriv in antal hjul:");
                noOfWheels = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void CheckFull(IReadGarage<vehiclesInGarage> vehicleInGarageList)
        {
            int countVehiclesInGarage = 0;
            var items = vehicleInGarageList.GetAll();
            foreach (var item in items)
            {
                countVehiclesInGarage++;
            }
            if (countVehiclesInGarage > 6)
            {
                //Console.WriteLine("Tvärr är garaget fullt, vänligen kom tillbaka en annan gång.");
                throw new ArgumentOutOfRangeException("invalid size");
            }
        }

    }
}
