using SaintSeiya.Models;
using SaintSeiya.Models.Characters.BronzeKnights;
using SaintSeiya.Models.Characters.GoldenKnights;
using SaintSeiya.Models.Characters.Soldiers;
using SaintSeiya.Models.Characters.SteelKnights;
using SaintSeiya.Models.Characters.SilverKnights;

System.Console.WriteLine($"================ Saint Seiya ================");

System.Console.WriteLine("Escolha seu personagem ");

System.Console.WriteLine(" Selecione (1) para Soldados. ");
System.Console.WriteLine(" Selecione (2) paraCavaleiros de Bronse. ");
System.Console.WriteLine(" Selecione (3) paraCavaleiros de Prata. ");
System.Console.WriteLine(" Selecione (4) paraCavaleiros de Ouro. ");

System.Console.WriteLine($"===============================================");

string? opcao = System.Console.ReadLine();

if (opcao == "1")
{

    Soldiers soldiers = new Soldiers();
    soldiers.Soldier();

    soldiers.Defend();

    System.Console.WriteLine($"{soldiers}");
    System.Console.WriteLine("");

    System.Console.WriteLine("Para atacar selecione (1) - Para defender Selecione (2)");

    string? acao = System.Console.ReadLine();

    if (acao == "1")
    {
        System.Console.WriteLine(soldiers.LaunchAttack());
    }
    else if (acao == "2")
    {
        System.Console.WriteLine(soldiers.Defend());

    }


}