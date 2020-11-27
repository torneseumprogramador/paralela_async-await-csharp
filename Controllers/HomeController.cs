using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AsyncAwaitDotnet5.Models;

namespace AsyncAwaitDotnet5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            // var humano = new Humano("danilo", "ssdsdds");
        

            // var usuario = new Usuario("Danilo", "1232123", "Rua dss");
            var usuario = new Usuario { Nome = "Danilo", Telefone = "1232123", Endereco = "Rua dss" };
            // usuario.Nome = "123w";
            Console.WriteLine(usuario);

            var carro = new Carro{ Nome = "23", Marca = "ssss"};
            Console.WriteLine(carro);

            var carro2 = new Carro{Marca = "ssss"};
            carro2.Nome = "dsdsds";
            Console.WriteLine(carro2);

            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            ViewBag.clientes = await Cliente.AllAsync();
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.clientes = Cliente.All();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
