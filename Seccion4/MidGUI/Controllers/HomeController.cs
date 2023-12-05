using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MidGUI.Models;
using Newtonsoft.Json;

namespace MidGUI.Controllers;

public class HomeController : Controller
{
    // Declara una variable privada para el cliente HTTP
    private readonly HttpClient httpClient;

    public HomeController()
    {
        // Inicializa el cliente HTTP y establece la dirección base para las solicitudes
       httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:5001/") 
        };
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        // Realiza una solicitud GET a la ruta "programa/algoritmo/solucion" y obtiene la respuesta
        HttpResponseMessage response = await httpClient.GetAsync("programa/algoritmo/solucion");

        var json = await response.Content.ReadAsStringAsync();
        List<Midle>? Midles = JsonConvert.DeserializeObject<List<Midle>>(json);
        var modelo = new  MidleViewModel
        {
            Listamidles = Midles
        };
        ViewBag.Title ="Pagina Principal";
        return View(modelo);

    }

    [HttpGet]
    public IActionResult Consulta()
    {
        ViewBag.Title = "Consulta";
        return View();
    }
    [HttpGet]
    public IActionResult Respuesta(string Res)
    {
        ViewBag.Title = "Respuesta";
        ViewBag.Response = Res;
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Consulta(Input input)
    {
        // Realiza una solicitud GET a la URL especificada, que incluye los valores de input.Consulta e input.Usuario
        HttpResponseMessage response = await httpClient.GetAsync($"programa/algoritmo/solucion/{input.Consulta},{input.Usuario}");
        var json = await response.Content.ReadAsStringAsync();
        dynamic result = JsonConvert.DeserializeObject(json);
        ViewBag.Title = "Consulta";
        string Res = result.result;
        return RedirectToAction("Respuesta", new { Res });
    }

    

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
