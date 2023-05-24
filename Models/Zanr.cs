using System.Text.Json.Serialization;

namespace VirtualDj.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Zanr
    {
        Pop =1 ,
        Zabavna = 2,
        Narodna = 3 ,
        Rok = 4,
        RnB = 5,
        Djecija = 6,
    }
}
