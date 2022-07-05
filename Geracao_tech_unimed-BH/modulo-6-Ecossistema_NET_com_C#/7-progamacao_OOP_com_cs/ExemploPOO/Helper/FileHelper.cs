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

        public void LinstandoArquivos(string caminho)
        {
            // var retornoArquivo = Directory.GetFiles(caminho, "*.txt", SearchOption.AllDirectories);
            // var retornoArquivo = Directory.GetFiles(caminho, "*2.txt", SearchOption.AllDirectories);
            var retornoArquivo = Directory.GetFiles(caminho, "*2*", SearchOption.AllDirectories);

            foreach (var retorno in retornoArquivo)
            {
                System.Console.WriteLine(retorno);
            }

        }
    }
}