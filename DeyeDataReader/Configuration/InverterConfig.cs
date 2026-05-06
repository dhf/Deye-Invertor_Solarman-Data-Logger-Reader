namespace DeyeDataReader.Configuration
{
    public class InverterConfig
    {
        public string InverterIp { get; set; } = "192.168.112.102";
        public int InverterPort { get; set; } = 8899;
        public long InverterSerialNumber { get; set; } = 2796729831;

        public string InverterRegistersMapFile { get; set; } = "DEYE_SUN_SG04LP3_EU_Map.json";

        public bool Verbose { get; set; } = true;
    }
}