using System;

namespace VehicleCatalogue
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            HashSet<Vehicle> vehicleCatalogue = new HashSet<Vehicle>();

            string command;

            while ((command = Console.ReadLine()!) != "End")
            {
                List<string> commandsTokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                vehicleCatalogue.Add(new Vehicle(commandsTokens[0], commandsTokens[1], commandsTokens[2], int.Parse(commandsTokens[3])));
            }

            string token;
            while ((token = Console.ReadLine()!) != "Close the Catalogue")
            {
                var matchedVehicle = vehicleCatalogue.FirstOrDefault(x => x.Model.ToLower() == token.ToLower());
                if (matchedVehicle != null)
                {
                    Console.WriteLine(matchedVehicle.ToString());
                }
            }

            Console.WriteLine(string.Join("\n", vehicleCatalogue));
            Console.WriteLine($"Cars have average horsepower of: {vehicleCatalogue.Where(x => x.Type.ToLower() == "car").Average(x => x.HorsePower):f2}");
            Console.WriteLine($"Trucks have average horsepower of: {vehicleCatalogue.Where(x => x.Type.ToLower() == "truck").Average(x => x.HorsePower):f2}");
        }
    }
}
