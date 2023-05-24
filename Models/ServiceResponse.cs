namespace VirtualDj.Models
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public string Posao { get; set; } = "Pjevaci";
        public bool Profesija { get; set; } = true;
    }
}
