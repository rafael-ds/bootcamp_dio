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

        public void CriandoDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }
        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho, apagarArquivos);
        }

        public void CrindoUmArquivoTexto(string caminho, string conteudo)
        {
            if (!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
        }

        public void CriarTextoSteam(string caminho, List<string> conteudo)
        {

            using (var stream = File.CreateText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }

        }
    }
}