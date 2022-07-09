namespace SaintSeiya.Models.Characters.SilverKnights
{
    public class MenuSilverKnights
    {
        public void ChooseKnight()
        {
            Albion albion = new Albion();
            Algol algol = new Algol();
            CrystalMaster crystalMaster = new CrystalMaster();
            Marin marin = new Marin();
            Misty misty = new Misty();
            Shina shina = new Shina();

            AttackDefend attackAndDefend = new AttackDefend();

            while (true)
            {
                System.Console.WriteLine($"================ Cavaleiros de Aço ================");

                System.Console.WriteLine(" Digite (1) para escolher Albion de Cefeu. ");
                System.Console.WriteLine(" Digite (2) para escolher Algol de Perseu. ");
                System.Console.WriteLine(" Digite (3) para escolher Marin de Águia. ");
                System.Console.WriteLine(" Digite (4) para escolher Misty de Lagarto. ");
                System.Console.WriteLine(" Digite (5) para escolher Marin de Combra. ");
                System.Console.WriteLine(" Digite (6) para escolher Cavaleiro de Crystal. ");
                System.Console.WriteLine(" Digite (0) para voltar ao menu principal. ");

                System.Console.WriteLine($"=======================================================");

                string? option = System.Console.ReadLine();

                switch (option)
                {
                    case "1":
                        albion.Cefeu();
                        System.Console.WriteLine($"\n{albion}\n");

                        attackAndDefend.attackDefend(albion);
                        break;

                    case "2":
                        algol.Perseus();
                        System.Console.WriteLine($"\n{algol}\n");
                        attackAndDefend.attackDefend(algol);
                        break;

                    case "3":
                        marin.Eagle();
                        System.Console.WriteLine($"\n{marin}\n");
                        attackAndDefend.attackDefend(marin);
                        break;

                    case "4":
                        misty.Lizard();
                        System.Console.WriteLine($"\n{misty}\n");
                        attackAndDefend.attackDefend(misty);
                        break;

                    case "5":
                        shina.Snake();
                        System.Console.WriteLine($"\n{shina}\n");
                        attackAndDefend.attackDefend(shina);
                        break;

                    case "6":
                        crystalMaster.Crystal();
                        System.Console.WriteLine($"\n{crystalMaster}\n");
                        attackAndDefend.attackDefend(crystalMaster);
                        break;
                }

                if (option == "0")
                {
                    System.Console.WriteLine("\nRetornando ao menu...\n");
                    break;
                }
            }
        }
    }
}