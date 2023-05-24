using VirtualDj.Models;

namespace VirtualDj.Dtos.DTOPjesma
{
    public class AddPjesmaDto
    {
       
        public string NazivPjesme { get; set; } = "Okano";
        public string Izvodjac { get; set; } = "Zdravko Colic";
        public int Trending { get; set; } = 3;
        public Zanr Tip { get; set; } = Zanr.Zabavna;
    }
}
