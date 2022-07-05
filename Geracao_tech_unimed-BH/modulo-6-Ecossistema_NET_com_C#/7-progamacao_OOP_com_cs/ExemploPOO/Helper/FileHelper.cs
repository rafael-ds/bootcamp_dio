namespace ExemploPOO.Interfaces
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornarCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories); // retorna um array de strings

            foreach (var retorno in retornarCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }
    }
}