using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoMatematicas.Models;

namespace ProyectoMatematicas.Controllers
{
    public class MatematicasController : Controller
    {
        [HttpPost]
        public IActionResult SumarNumeros(int num1, int num2)
        {
            @ViewBag.num1 = num1;
            @ViewBag.num2 = num2;
            int suma = num1 + num2;
            return View(suma);
        }
        public IActionResult SumarNumeros()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicar(int numero)
        {
            List<FilaMultiplicar> tabla = new List<FilaMultiplicar>();
            for(int i = 1; i<= 10; i++)
            {
                FilaMultiplicar f = new FilaMultiplicar();
                f.Operacion = numero + " * " + i;
                f.Resultado = numero * i;
                tabla.Add(f);

            }

            return View(tabla);
        }

        public IActionResult TablaMultiplicar()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Collazt(int numero)
        {
            ViewData["NUMERO"] = numero;
            List<int> aleatorios = new List<int>();
            Random random = new Random();
            for(int i = 0; i <10; i++)
            {
                int aleat = random.Next(1, 100);
                aleatorios.Add(aleat);
            }
            return View(aleatorios);
        }
    }
}