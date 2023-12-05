// Declara una función que toma una cadena y devuelve los caracteres centrales
Func<string, string> obtenerCaracteresCentrales = s => 
{
    // Calcula el índice del centro de la cadena para determinar el índice de inicio
    int centro = s.Length / 2;
    /* Si la longitud de la cadena es par (cuando es impar se le resta uno al centro), devuelve los dos caracteres centrales
       Si es impar, devuelve el carácter central apoyándose de la función Substring la cual como parámetros 
       recibe el índice de inicio y la longitud */
    return s.Length % 2 == 0 ? s.Substring(centro - 1, 2) : s.Substring(centro, 1);
};

// Solicita al usuario que ingrese una cadena
Console.WriteLine("Digite la entrada");

// Lee la entrada del usuario y la asigna a la variable 'entrada'
string entrada = Console.ReadLine();

// Llama a la función 'obtenerCaracteresCentrales' con la entrada del usuario y escribe el resultado en la consola
Console.WriteLine(obtenerCaracteresCentrales(entrada));


  