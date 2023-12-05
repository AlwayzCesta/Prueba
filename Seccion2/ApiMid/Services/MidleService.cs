using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMid.Services
{
    public class MidleService : IMidleService
    {
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
    }
    public interface IMidleService
    {
        String obtenerCaracteresCentrales(string s);
    }
}