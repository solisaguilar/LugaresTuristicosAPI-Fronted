namespace LugaresTuristicosAPI.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public string FechaReserva { get; set; }
        public string NombreCliente { get; set; }
        public int LugarId { get; set; } 
        public Lugar Lugar { get; set; }
    }
}
