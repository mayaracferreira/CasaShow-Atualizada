namespace CasaShow.Models
{
    public class CasadeShow
    {
        public int Id {get;set;}

        public string Nome {get;set;}

        public string Endereço {get;set;}

        public override string ToString(){
            return "Id: " + this.Id + " Nome: " + this.Nome;
        }
    }
}