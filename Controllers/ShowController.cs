using System;
using Microsoft.AspNetCore.Mvc;
using CasaShow.Controllers;
using CasaShow.Data;
using CasaShow.Models;
using System.Linq;

namespace CasaShow.Controllers
{
    public class ShowController : Controller 
    {

     private readonly ApplicationsDbContext database;

        public ShowController (ApplicationsDbContext database) {
                this.database = database;
    
        }
       public IActionResult Cadastrar (){
           return View ();

       } 

       public IActionResult Editar (int Id){
           return RedirectToAction ("Cadastrar");
       }

       
       public IActionResult Deletar (int ID){
            Show aux = database.Shows.First (aux => aux.Id == ID);
          database.Shows.Remove(aux);
          database.SaveChanges();
           return RedirectToAction ("Proximos"); 
       }

        [HttpPost]
       public IActionResult Salvar (Show show){
           database.Shows.Add(show);  
           database.SaveChanges();
           return RedirectToAction ("Proximos");
       }


        public IActionResult Proximos()  {

            var proximos = database.Shows.ToList();

            return View(proximos);
        }
    }
}