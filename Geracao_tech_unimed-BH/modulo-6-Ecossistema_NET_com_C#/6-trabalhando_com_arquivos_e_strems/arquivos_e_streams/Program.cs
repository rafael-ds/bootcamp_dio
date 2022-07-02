var path = Path.Combine(Environment.CurrentDirectory, "teste.txt");

// File.Create(path);

using var sw = File.CreateText(path);
sw.WriteLine("Esta é a linha 1");
sw.WriteLine("Esta é a linha 2");
sw.WriteLine("Esta é a linha 3");
sw.WriteLine("Esta é a linha 4");
sw.WriteLine("Esta é a linha 5");
// sw.Flush();
