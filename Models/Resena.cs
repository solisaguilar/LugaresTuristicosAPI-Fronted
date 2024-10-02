namespace LugaresTuristicosAPI.Models
{
    public class Resena
    {
        public int Id { get; set; }
        public string Comentario { get; set; }
        public string FechaResena { get; set; }
        public int LugarId { get; set; } 
        public Lugar Lugar { get; set; }
    }
}
