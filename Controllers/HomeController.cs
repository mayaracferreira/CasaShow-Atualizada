using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CasaShow.Models;
using CasaShow.Data;
using Microsoft.EntityFrameworkCore;

namespace CasaShow.Controllers
{
    public class HomeController : Controller
    {

         public readonly ApplicationsDbContext database;

    
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,ApplicationsDbContext database)
        {
                this.database = database;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ingressos()
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

            List <Categoria> cateLista = new List<Categoria>();
            cateLista.Add(c1);
            cateLista.Add(c2);
            cateLista.Add(c3);
;
            database.AddRange(cateLista);

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
            return Content("Relacionamento"); 
        

            Evento e1 = new Evento ();
            e1.Nome = "Marilia Mendonça";
            e1.Categoria = database.Categorias.First(c => c.Id == 1);

            Evento e2 = new Evento ();
            e2.Nome = "FalaMansa";
            e2.Categoria = database.Categorias.First(c => c.Id == 2);

            Evento e3 = new Evento ();
            e3.Nome = "Sambô";
            e3.Categoria = database.Categorias.First(c => c.Id == 3);

            database.Add(e1);
            database.Add(e2);
            database.Add(e3);

            database.SaveChanges();

            

            var listaDeEventos = database.Eventos.Include(e => e.Categoria).ToList();

            listaDeEventos.ForEach(evento => {
                Console.WriteLine(evento.ToString());
            }); 


            return Content("Relacionamento");

        }

                public IActionResult Contato()
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
