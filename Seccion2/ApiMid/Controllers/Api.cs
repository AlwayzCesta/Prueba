using ApiMid.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiMid.Controllers;

[ApiController]
[Route("/programa/algoritmo/solucion")]
public class Api : ControllerBase
{
    // Utilizamos inyección de dependencias para obtener una instancia de IMidleService.
    // Esto nos permite desacoplar la implementación concreta de IMidleService de nuestro controlador,
    // haciendo que nuestro código sea más modular y fácil de probar.
    private IMidleService _midleService;
    public Api( IMidleService midleService)
    {
        _midleService = midleService;
    }
    [HttpGet("{entrada}")]
    public IActionResult ObtenerMitad(string entrada)
    {
        // Llamamos al método obtenerCaracteresCentrales de nuestro servicio con la entrada proporcionada.
        string salida = _midleService.obtenerCaracteresCentrales(entrada);
        // Creamos un objeto anónimo con la salida para devolver como JSON.
        var result = new { result = salida };
        // Devolvemos un 200 OK con el resultado en formato JSON.
        return Ok(result);
    }
}
