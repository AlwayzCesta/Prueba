// Crear un diccionario para almacenar las partes de la cara
var partesCara = new Dictionary<string, string>
{
    {"ojos", ""},
    {"cejas", ""},
    {"nariz", ""},
    {"boca", ""},
    {"cabello", ""},
    {"orejas", ""},
    {"contorno", ""},
    {"menton", ""}
};
// Solicitar al usuario que ingrese los caracteres para cada parte de la cara
foreach (var parte in partesCara.Keys.ToList())
{
    Console.WriteLine($"Ingrese los caracteres para {parte}:");
    partesCara[parte] = Console.ReadLine();
}
// Definir una función lambda para dibujar la cara
Func<string, string, string, string, string, string, string, string, string> dibujar_cara = 
    (ojos, cejas, nariz, boca, cabello, orejas, contorno, menton) =>
{
    // Iniciar la cadena que representará la cara
    string cara = $"\n\n {cabello}{cabello}{cabello}{cabello}{cabello}\n";
    // Agregar las cejas a la cara
    cara += $"{contorno} {cejas[0]} {cejas[1]} {contorno}\n";
    // Agregar los ojos a la cara
    cara += $"{orejas[0]} {ojos} {ojos} {orejas[1]}\n";
    // Agregar la nariz a la cara
    cara += $"{contorno}  {nariz}  {contorno}\n";
    // Agregar la boca a la cara
    cara += $"{contorno} {boca[0]}{boca[1]}{boca[2]} {contorno}\n";
    // Agregar el contorno de la cara
    cara += $" {contorno}   {contorno} \n";
    // Agregar el mentón a la cara
    cara += $"  {menton}\n";

    // Devolver la cara dibujada
    return cara;
};
// Dibujar la cara con los caracteres ingresados por el usuario
string resultado = dibujar_cara(partesCara["ojos"], partesCara["cejas"], partesCara["nariz"], partesCara["boca"], partesCara["cabello"], partesCara["orejas"], partesCara["contorno"], partesCara["menton"]);
// Mostrar el resultado
Console.WriteLine(resultado);