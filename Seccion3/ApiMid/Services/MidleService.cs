using Microsoft.AspNetCore.Mvc;
using ApiMid.Models;

namespace ApiMid.Services
{
    public class MidleService : IMidleService
    {
        // Instanciamos _Context para hacer uso de EF Core
        ApiContext _context;
        // En el constructor de MidleService, se inyecta una instancia de ApiContext.
        public MidleService(ApiContext context)
        {
            _context = context;
        }

        // Declara una función que toma una cadena y devuelve los caracteres centrales
        public string obtenerCaracteresCentrales(string s)
        {
            // Calcula el índice del centro de la cadena para determinar el índice de inicio
            int centro = s.Length / 2;
            /* Si la longitud de la cadena es par (cuando es impar se le resta uno al centro), devuelve los dos caracteres centrales
            Si es impar, devuelve el carácter central apoyándose de la función Substring la cual como parámetros 
            recibe el índice de inicio y la longitud */
            return s.Length % 2 == 0 ? s.Substring(centro - 1, 2) : s.Substring(centro, 1);
        }
        //Guardamos el objeto midle ayudandonos de _context
        public void guadar([FromBody] Midle midle)
        {
            _context.Add(midle);
            _context.SaveChanges();
        }
        // Seccion 4
        // Traer Datos
        public IEnumerable<Midle> ObtenerDatos()
        {
            return _context.Midle;
        }
    }
    public interface IMidleService
    {
        String obtenerCaracteresCentrales(string s);
        void guadar([FromBody] Midle midle);
        IEnumerable<Midle> ObtenerDatos();
    }
}