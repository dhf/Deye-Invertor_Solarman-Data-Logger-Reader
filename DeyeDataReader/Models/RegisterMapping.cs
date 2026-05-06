using System.Text.Json.Serialization;

namespace DeyeDataReader.Models
{
    public class RegisterMapping
    {
        [JsonPropertyName("registers")]
        public Register[] Registers { get; set; } = Array.Empty<Register>(); 

        [JsonPropertyName("mappings")]
        public RegisterMappingRoot[] Mappings { get; set; } = Array.Empty<RegisterMappingRoot>(); 
    }

    public class Register
    {
        [JsonPropertyName("start")]
        public string Start { get; set; } = string.Empty;
        
        [JsonPropertyName("end")]
        public string End { get; set; } = string.Empty;

    }
    
    public class Mapping
    {
        [JsonPropertyName("titleEN")]
        public string TitleEN { get; set; } = string.Empty;

        [JsonPropertyName("registers")]
        public string[] Registers { get; set; } = Array.Empty<string>();

        [JsonPropertyName("domoticzIdx")]
        public int DomoticzIdx { get; set; }

        [JsonPropertyName("optionRanges")]
        public object[] OptionRanges { get; set; } = Array.Empty<object>();

        [JsonPropertyName("ratio")]
        public double Ratio { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; } = string.Empty;

        [JsonPropertyName("graph")]
        public int Graph { get; set; }

        [JsonPropertyName("metric_type")]
        public string MetricType { get; set; } = string.Empty;

        [JsonPropertyName("metric_name")]
        public string MetricName { get; set; } = string.Empty;

        [JsonPropertyName("label_name")]
        public string LabelName { get; set; } = string.Empty;

        [JsonPropertyName("label_value")]
        public string LabelValue { get; set; } = string.Empty;
    }

    public class RegisterMappingRoot
    {
        [JsonPropertyName("directory")]
        public string Directory { get; set; } = string.Empty;

        [JsonPropertyName("items")]
        public Mapping[] Items { get; set; } = Array.Empty<Mapping>();
    }
}





