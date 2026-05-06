using System.Text.Json;
using DeyeDataReader.Configuration;
using DeyeDataReader.Services;

namespace DeyeDataReader
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Deye Inverter Data Reader");
            Console.WriteLine("=========================");
            Console.WriteLine();

            var config = new InverterConfig
            {
                InverterIp = "192.168.112.102",
                InverterPort = 8899,
                Verbose = false,
                InverterSerialNumber = 2796729831,
            };

            var solarmanService = new SolarmanDataLoggerService(new InverterConfig());

            try
            {
                Console.WriteLine("Connecting to inverter...");
                var inverterData = await solarmanService.GetInverterDataAsync();

                if (inverterData != null)
                {
                    Console.WriteLine("Successfully retrieved inverter data!");
                    Console.WriteLine();

                    var json = JsonSerializer.Serialize(inverterData, new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

                    Console.WriteLine("*** JSON output:");
                    Console.WriteLine(json);
                }
                else
                {
                    Console.WriteLine("Failed to retrieve inverter data. Check connection and configuration.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            //Console.ReadLine();
        }
    }
}