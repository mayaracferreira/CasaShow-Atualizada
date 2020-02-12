using System;

namespace CasaShow.Models
{
    public class Show
    {
        public int Id {get;set;}

        public string Nome {get;set;}

        public string Data {get;set;}

        public float Valor {get;set;}

        public DateTime Hora {get;set;}

        public string Casa {get;set;}

        public string Categoria {get;set;}
    }
}