using Övning_5;
using Övning_5.Data;
using Övning_5.FunctionsBase;
using Övning_5.FunctionsSpecial;
using Övning_5.Vehicles;

ListVehicles list = new();
AddVehicles addVehicle = new();

//var garageBuildingsList = new Garage<garageBuildings>();
var vehicleInGarageList = new SqlGarage<vehiclesInGarage>(new StorageApp());
var airplanesInGarageList = new SqlGarage<Airplane>(new StorageApp());
var boatsInGarageList = new SqlGarage<Boat>(new StorageApp());
var bussesInGarageList = new SqlGarage<Bus>(new StorageApp());
var carsInGarageList = new SqlGarage<Car>(new StorageApp());
var motorcyclesInGarageList = new SqlGarage<Motorcycle>(new StorageApp());


while (true)
        {
            Console.WriteLine("Skriv in önskat menyval:"
                + "\n1. Visa samtliga fordon i garaget"
                + "\n2. Visa vilka fordonstyper som finns och hur många av varje som är parkerad"
                + "\n3. Lägg till fordon"
                + "\n4. Skapa garage"
                + "\n5. Lägg till grupp med test fordon"
                + "\n6. Sök fordon på reg nummer"
                + "\n7. Sök fordon efter egenskaper"
                + "\n0. Exit the application");
            char input = ' ';
            try
            {
                input = Console.ReadLine()![0];
            }
            catch (IndexOutOfRangeException)
            {
                Console.Clear();
                Console.WriteLine("Vänligen gör ett val.");
            }
            switch (input)
            {
                case '1': //Visa samtliga fordon i garaget"
                    list.WriteAllToConsole(vehicleInGarageList);
                    break;
                case '2': //Visa vilka fordonstyper som finns och hur många av varje som är parkerad"
                    list.WriteVehiclesToConsole(vehicleInGarageList);
                    list.WriteAirplaneToConsole(airplanesInGarageList);
                    list.WriteBoatToConsole(boatsInGarageList);
                    list.WriteBusToConsole(bussesInGarageList);
                    list.WriteCarToConsole(carsInGarageList);
                    list.WriteMotorcycleToConsole(motorcyclesInGarageList);

            break;
                case '3': //Lägg till fordon"
                    addVehicle.CheckFull(vehicleInGarageList);
                    Console.WriteLine("Vänligen välj vilket typ av fordon som ska läggas till:\n1.Airplane\n2.Boat\n3.Bus\n4.Car\n5.Motorcycle");
                    string choice = Console.ReadLine();        

                    if (choice == "1")
                        {
                            addVehicle.AddAirplaneToList2(airplanesInGarageList);
                        }
                    else if (choice == "2")
                        {
                            addVehicle.AddBoatToList2(boatsInGarageList);
                        }
                    else if (choice == "3")
                        {
                            addVehicle.AddBusToList2(bussesInGarageList);
                        }
                    else if (choice == "4")
                        {
                            addVehicle.AddCarToList2(carsInGarageList);
                        }
                    else if (choice == "5")
                        {
                            addVehicle.AddMotorcycleToList2(motorcyclesInGarageList);
                        }
                    else
                        {
                            Console.WriteLine("Felaktigt val, vänligen försök igen");
                        }
                    break;
                case '4': //Skapa garage
                    //Fick problem med denna pga hur jag började sätta upp hela basen när jag satte allt med dbSet.
                    //Lyckades inte lista ut hur jag kunde sätta en Capacity på ett bra sätt.
                    Console.WriteLine("Denna funktion saknas, skall implementeras.");
                    break;
                case '5': //Lägg till grupp med test fordon
                    addVehicle.AddVehiclesTest(vehicleInGarageList);
                    break;
                case '6': //Sök fordon på reg nummer
                    list.GetVehicleById(vehicleInGarageList);
                    break;
                case '7': //Sök fordon efter egenskaper
                    //Fick problem med denna pga hur jag började sätta upp hela basen när jag satte allt med dbSet.
                    //Lyckades inte lista ut hur jag kunde söka på flera val i listan.
                    Console.WriteLine("Denna funktion saknas, skall implementeras."); 
                break;

                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Vänligen skriv in ett val enligt menyn");
                    break;
            }
        }

