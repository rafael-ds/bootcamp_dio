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
    System.Console.WriteLine(" Digite (3) para Cavaleiros de Bronze. ");
    System.Console.WriteLine(" Digite (4) para Cavaleiros de Prata. ");
    System.Console.WriteLine(" Digite (5) para Cavaleiros de Ouro. ");
    System.Console.WriteLine(" Digite (0) para Sair. ");

    System.Console.WriteLine($"===============================================");

    string? option = System.Console.ReadLine();

    switch (option)
    {
        case "1":
            MenuSoldier optionSoldier = new MenuSoldier();
            optionSoldier.Option();
            break;

        case "2":
            MenuSteelKnights optionSteelKnigth = new MenuSteelKnights();
            optionSteelKnigth.ChooseKnight();
            break;

        case "3":
            MenuBronzeKnigths optionBronzeKnights = new MenuBronzeKnigths();
            optionBronzeKnights.ChooseKnight();
            break;

        case "4":
            MenuSilverKnights optionSilverKnights = new MenuSilverKnights();
            optionSilverKnights.ChooseKnight();
            break;

        case "5":
            MenuGoldenKnights optionGoldenKnights = new MenuGoldenKnights();
            optionGoldenKnights.ChooseKnight();
            break;
        default:
            System.Console.WriteLine("Informe uma opção válida");
            break;
    }

    if (option == "0")
    {
        System.Console.WriteLine("Saindo...");
        break;
    }

}
