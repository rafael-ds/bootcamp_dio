namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public int Idade { get; set;}
        public string? Nome {get; set;}

         public void Apresentar(){
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos");
         }

    }
}