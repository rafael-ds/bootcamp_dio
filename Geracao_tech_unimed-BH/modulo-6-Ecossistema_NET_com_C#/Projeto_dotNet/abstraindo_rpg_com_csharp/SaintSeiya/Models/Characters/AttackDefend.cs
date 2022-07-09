namespace SaintSeiya.Models.Characters
{
    public class AttackDefend
    {
        public void attackDefend(Knight knight)
        {
            while (true)
            {
                System.Console.WriteLine($"================ {knight.Name} ================");
                System.Console.WriteLine(" Digite (1) para Atacar. ");
                System.Console.WriteLine(" Digite (2) para Defender. ");
                System.Console.WriteLine(" Digite (0) para escoler outro personagem. ");
                System.Console.WriteLine($"===============================================");

                string? optionknightBonze = System.Console.ReadLine();

                switch (optionknightBonze)
                {
                    case "1":
                        System.Console.WriteLine(knight.LaunchAttack());
                        break;

                    case "2":
                        System.Console.WriteLine(knight.Defend());
                        break;
                }

                if (optionknightBonze == "0")
                {
                    System.Console.WriteLine("\nRetornando ao menu...\n");
                    break;
                }
            }

        }
    }
}