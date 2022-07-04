namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar(){
            Console.WriteLine($"Meu nome é {Nome} tenho {Idade} anos e meu salario é R${Salario}");
         }
    }
}