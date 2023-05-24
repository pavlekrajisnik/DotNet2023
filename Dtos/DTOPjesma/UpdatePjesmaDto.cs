using VirtualDj.Models;

namespace VirtualDj.Dtos.DTOPjesma
{
    public class UpdatePjesmaDto
    {
        public int Id { get; set; }
        public string NazivPjesme { get; set; } =string.Empty;
        public string Izvodjac { get; set; } = string.Empty;
        public int Trending { get; set; }
        public Zanr Tip { get; set; } = Zanr.Zabavna;
    }
}
