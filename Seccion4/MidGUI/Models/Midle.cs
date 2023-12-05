namespace MidGUI.Models
{
    public class Midle
    {
        //Este es el modelo para la tabla midle
        public Guid MidleID { get; set; }
        public string Usuario { get; set; }
        public string Request { get; set; }
        public DateTime FechaRequest { get; set; }
        public string Response { get; set; }
        public DateTime FechaResponse { get; set; }
    }
    public class MidleViewModel
    {
        public List<Midle>? Listamidles { get; set; }
    }
}