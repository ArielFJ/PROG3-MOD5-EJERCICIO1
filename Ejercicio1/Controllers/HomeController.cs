using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ejercicio1.Models;

namespace Ejercicio1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(NumsViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Binario", model);
            }
            return View(model);
        }

        public IActionResult Binario(NumsViewModel model)
        {
            foreach(int n in model.NumerosDecimales)
            {
                model.NumerosBinarios.Add(DecimalABinario(n));
            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private string DecimalABinario(int n)
        {
            string bin = "";
            while (true)
            {
                if (n % 2 != 0)
                    bin = "1" + bin;
                else
                    bin = "0" + bin;
                n /= 2;
                if (n <= 0) break;
            }
            return bin;
        }
    }
}
