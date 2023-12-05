using ApiMid.Models;
using ApiMid.Services;
using Microsoft.AspNetCore.Mvc;
using System;

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
    //Retornamos los datos de la base de datos
    [HttpGet]
    public IActionResult Datos()
    {
        return Ok(_midleService.ObtenerDatos());
    }

    [HttpGet("{entrada},{usuario}")]
    public IActionResult ObtenerMitad(string entrada , string usuario)
    {
        //Creamos un objeto del tipo Midle para alojar los datos que se enviaran al MidleService
        Midle midle = new Midle();
        midle.MidleID = Guid.NewGuid();
        midle.Usuario = usuario;
        midle.Request = HttpContext.Request.Path.ToString();
        midle.FechaRequest = DateTime.UtcNow;
        // Llamamos al método obtenerCaracteresCentrales de nuestro servicio con la entrada proporcionada.
        string salida = _midleService.obtenerCaracteresCentrales(entrada);
        // Creamos un objeto anónimo con la salida para devolver como JSON.
        var result = new { result = salida };

        midle.Response = result.ToString();
        midle.FechaResponse = DateTime.UtcNow;
        // Guardamos el objeto midle en la base de datos.
        _midleService.guadar(midle);

        // Devolvemos un 200 OK con el resultado en formato JSON.
        return Ok(result);
    }
    
}
