using SaintSeiya.Models;
using SaintSeiya.Models.Characters.BronzeKnights;
using SaintSeiya.Models.Characters.GoldenKnights;
using SaintSeiya.Models.Characters.Soldiers;
using SaintSeiya.Models.Characters.SteelKnights;
using SaintSeiya.Models.Characters.SilverKnights;


while (true)
{
    System.Console.WriteLine($"================ Saint Seiya ================");

    System.Console.WriteLine("Escolha seu personagem ");

    System.Console.WriteLine(" Digite (1) para Soldados. ");
    System.Console.WriteLine(" Digite (2) para Cavaleiros de Aço. ");
    System.Console.WriteLine(" Digite (3) para Cavaleiros de Bronse. ");
    System.Console.WriteLine(" Digite (4) para Cavaleiros de Prata. ");
    System.Console.WriteLine(" Digite (5) para Cavaleiros de Ouro. ");
    System.Console.WriteLine(" Digite (0) para Sair. ");

    System.Console.WriteLine($"===============================================");

    string? opcao = System.Console.ReadLine();

    switch (opcao)
    {
        case "1":            
            MenuSoldier optionSoldier = new MenuSoldier();
            optionSoldier.Option();            
            break;

        case "2":
            MenuBronzeKnigths optionBronzeKnights = new MenuBronzeKnigths();
            optionBronzeKnights.ChooseKnight();
            break;

        case "3":
            System.Console.WriteLine("Cavaleiros de Bonze");
            break;
        case "4":
            System.Console.WriteLine("Cavaleiros de Prata");
            break;
        case "5":
            System.Console.WriteLine("Cavaleiros de Ouro");
            break;
        default:
            System.Console.WriteLine("Informe uma opção válida");
            break;
    }

    if(opcao == "0"){
        System.Console.WriteLine("Saindo...");
        break;
    }

}
