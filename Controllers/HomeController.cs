using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CasaShow.Models;
using CasaShow.Data;

namespace CasaShow.Controllers
{
    public class HomeController : Controller
    {

         public readonly ApplicationDbContext database;

    
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext database)
        {
                this.database = database;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult Teste ()
        {

             
            Categoria c1 = new Categoria ();
            c1.Nome = "Sertanejo";
            Categoria c2 = new Categoria ();
            c2.Nome = "Forró";
            Categoria c3 = new Categoria ();
            c3.Nome = "Samba";

            List <Categoria> catLista = new List<Categoria>();
            catLista.Add(c1);
            catLista.Add(c2);
            catLista.Add(c3);
;
            database.AddRange(catLista);

            database.SaveChanges(); 

            var listaDeCategorias = database.Categorias.ToList ();

            Console.WriteLine("------------------Categorias----------------");


        listaDeCategorias.ForEach (Categoria => {
            Console.WriteLine (Categoria.ToString());

            Console.WriteLine("---------------------------------------------");
            
            });


            return Content ("Dados Salvos");
        }

        public IActionResult Relacionamento (){

            Evento e1 = new Evento ();
            e1.Nome = "Marilia Mendonça";
            e1.Categoria = database.Categorias.First(c => c.Id == 1);

            Evento e2 = new Evento ();
            e1.Nome = "FalaMansa";
            e1.Categoria = database.Categorias.First(c => c.Id == 2);

            Evento e3 = new Evento ();
            e1.Nome = "Sambô";
            e1.Categoria = database.Categorias.First(c => c.Id == 3);
            return Content("Relacionamento");

            database.Add(e1);
            database.Add(e2);
            database.Add(e3);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
