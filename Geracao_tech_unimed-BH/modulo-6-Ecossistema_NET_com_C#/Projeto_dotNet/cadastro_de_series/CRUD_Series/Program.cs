using System;
using CRUD_Series;

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Olá! Seja bem vindo ao Super Series");
    Console.WriteLine();

    Console.WriteLine("Informe a opção desejada:");
    Console.WriteLine();

    Console.WriteLine("1- Listar séries");
    Console.WriteLine("2- Inserir nova série");
    Console.WriteLine("3- Atualizar série");
    Console.WriteLine("4- Excluir série");
    Console.WriteLine("5- Visualizar série");
    Console.WriteLine("C- Limpar Tela");
    Console.WriteLine("X- Sair");
    Console.WriteLine();

    string? option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine("Super Séries a seu dispor!!!");
            ListSeries listSeries = new ListSeries();
            listSeries.List();
            break;

        case "2":
            InsertSeries insertSeries = new InsertSeries();
            insertSeries.Insert();
            break;

        case "3":
            Console.WriteLine("3- Atualizar série");
            // UpedateSeries();
            break;
        case "4":
            Console.WriteLine("4- Excluir série");
            // DeleteSeries();
            break;

        case "5":
            Console.WriteLine("5- Visualizar série");
            // ViewSeries();
            break;

        case "c":
            Console.WriteLine("C- Limpar Tela");
            // ClearScreen();
            break;

        default:
            Console.WriteLine("Digite uma opção válida. ");
            break;

    }

    if (option == "x")
    {
        System.Console.WriteLine("Saindo...");
        break;
    }

}