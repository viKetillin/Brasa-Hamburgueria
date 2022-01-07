using AppBrasa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppBrasa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        string urlApi = "https://localhost:44393/api/";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            string url = urlApi + "Franquias/recuperarFranquias";
            string response = await client.GetStringAsync(url);
            var franquias = JsonSerializer.Deserialize<List<Franquia>>(response);
            ViewData["Franquias"] = franquias;

            return View();
        }

        public async Task<IActionResult> CardapioAsync(decimal id)
        {
            HttpClient client = new HttpClient();

            string url = urlApi + "Franquias/recuperarFranquia?id=" + id;
            string responseFranquia = await client.GetStringAsync(url);
            var franquia = JsonSerializer.Deserialize<Franquia>(responseFranquia);
            ViewData["Franquia"] = franquia;       

            string urlCategorias = urlApi + "Categorias/recuperarCategorias";
            string responseCategorias = await client.GetStringAsync(urlCategorias);
            var categorias = JsonSerializer.Deserialize<List<Categoria>>(responseCategorias);
            ViewData["Categorias"] = categorias;

            string urlProdutoCardapio = urlApi + "ProdutoFranquia/recuperarCardapioFranquia?idFranquia=" + id;
            string responseProdutoCardapio = await client.GetStringAsync(urlProdutoCardapio);
            var produtoCardapio = JsonSerializer.Deserialize <List<ProdutoFranquia>>(responseProdutoCardapio);
            ViewData["ProdutoCardapio"] = produtoCardapio;     

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
