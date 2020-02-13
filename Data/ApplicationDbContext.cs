using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CasaShow.Models;

namespace CasaShow.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet <Show> Shows {get;set;}
        public DbSet <Categoria> Categorias {get;set;}
        public DbSet <Evento> Eventos {get;set;}

        public DbSet <Casa> Casas {get;set;}

                public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
