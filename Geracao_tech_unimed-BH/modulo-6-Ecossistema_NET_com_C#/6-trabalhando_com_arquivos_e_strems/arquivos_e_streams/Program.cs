using static System.Console;

WriteLine("Digite o nome do arquivo: ");
var nome = ReadLine();
nome = tratarCaracter(nome);

var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");
CriarArquivo(path);

WriteLine("Digite enter para finalizar: ");
ReadLine();


static string tratarCaracter(string nome)
{
    foreach (var caracter in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(caracter, '-');
    }
    return nome;

}


static void CriarArquivo(string path)
{
    try
    {
        // File.Create(path);
        using var sw = File.CreateText(path);
        sw.WriteLine("Esta é a linha 1");
        sw.WriteLine("Esta é a linha 2");
        sw.WriteLine("Esta é a linha 3");
        sw.WriteLine("Esta é a linha 4");
        sw.WriteLine("Esta é a linha 5");
        // sw.Flush();

    }
    catch
    {
        WriteLine("O nome do arquivo é inválido.");

    }

}