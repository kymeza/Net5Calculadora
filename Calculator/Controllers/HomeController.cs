using Net5Calculadora.Models;
using Net5Calculadora.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Net5Calculadora.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICalculadoraService _calculadoraService;

        public HomeController(ICalculadoraService calculadoraService)
        {
            _calculadoraService = calculadoraService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Operation model)
        {
            var operacion = model.OperationType.ToString();
            
            switch(operacion)
            {
                case "Suma":
                    model = _calculadoraService.Suma(model);
                    break;
                case "Multiplicacion":
                    model = _calculadoraService.Multiplicacion(model);
                    break;
                case "Division":
                    model = _calculadoraService.Division(model);
                    break;
                case "Resta":
                    model = _calculadoraService.Resta(model);
                    break;
            }
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
