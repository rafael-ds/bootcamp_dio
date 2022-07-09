namespace SaintSeiya.Models.Characters.Soldiers
{
    public class MenuSoldier
    {
        public void Option()
        {
            Soldiers soldier = new Soldiers();
            soldier.Soldier();
            System.Console.WriteLine($"\n{soldier}\n");

            while (true)
            {
                System.Console.WriteLine($"================ Soldado ================");

                System.Console.WriteLine(" Digite (1) para Atacar. ");
                System.Console.WriteLine(" Digite (2) para Defender. ");
                System.Console.WriteLine(" Digite (0) para escoler outro personagem. ");

                System.Console.WriteLine($"===============================================");

                string? opcao = System.Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        System.Console.WriteLine(soldier.LaunchAttack());
                        break;
                    case "2":
                        System.Console.WriteLine(soldier.Defend());
                        break;
                }

                if (opcao == "0")
                {
                    System.Console.WriteLine("\nRetornando ao menu...\n");
                    break;
                }
            }
        }
    }
}