CriarDiretorioGlobo();
// CriarArquivo();

var origem = Path.Combine(Environment.CurrentDirectory, "Brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory, "globo", "America do Sul", "Brasil", "Brasil.txt");
MoverArquivo(origem, destino);

static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("O aquivo não existe.");
        return;
    }

    if (File.Exists(pathDestino))
    {
        Console.WriteLine("O aquivo já existe.");
        return;
    }
    File.Move(pathOrigem, pathDestino);
}

static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Brasil.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("População: 213M");
        sw.WriteLine("IDM: 0,901");
        sw.WriteLine("Dados atualizado em: 0/0/0");

    }
}

static void CriarDiretorioGlobo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo");
    if (!Directory.Exists(path))
    {

        var dirGlobo = Directory.CreateDirectory(path);

        var dirAmNorte = dirGlobo.CreateSubdirectory("America do Norte");
        var dirAmCentral = dirGlobo.CreateSubdirectory("America Central");
        var dirAmSul = dirGlobo.CreateSubdirectory("America do Sul");

        dirAmNorte.CreateSubdirectory("USA");
        dirAmNorte.CreateSubdirectory("Mexico");
        dirAmNorte.CreateSubdirectory("Canadá");

        dirAmCentral.CreateSubdirectory("Costa Rica");
        dirAmCentral.CreateSubdirectory("Panama");

        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Argentina");
        dirAmSul.CreateSubdirectory("Paraguai");
    }
}


