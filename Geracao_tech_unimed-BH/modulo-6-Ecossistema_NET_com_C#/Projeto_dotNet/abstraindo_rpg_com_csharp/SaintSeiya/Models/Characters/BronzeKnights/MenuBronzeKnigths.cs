namespace SaintSeiya.Models.Characters.BronzeKnights
{
    public class MenuBronzeKnigths
    {
        public void ChooseKnight()
        {
            Hyoga hyoga = new Hyoga();
            Ikki ikki = new Ikki();
            Seiya seiya = new Seiya();
            Shiryu shiryu = new Shiryu();
            Shun shun = new Shun();

            AttackDefend attackAndDefend = new AttackDefend();

            while (true)
            {
                System.Console.WriteLine($"================ Cavaleiros de Bronze ================");

                System.Console.WriteLine(" Digite (1) para escolher Hyoga de Cisne. ");
                System.Console.WriteLine(" Digite (2) para escolher Ikki de Fenix. ");
                System.Console.WriteLine(" Digite (3) para escolher Seiya de Pegasus. ");
                System.Console.WriteLine(" Digite (4) para escolher Shyriu de Dragão. ");
                System.Console.WriteLine(" Digite (5) para escolher Shun de Andromeda. ");
                System.Console.WriteLine(" Digite (0) para voltar ao menu principal. ");

                System.Console.WriteLine($"=======================================================");

                string? option = System.Console.ReadLine();

                switch (option)
                {
                    case "1":
                        hyoga.Cygnus();
                        System.Console.WriteLine($"\n{hyoga}\n");

                        attackAndDefend.attackDefend(hyoga);
                        break;

                    case "2":
                        ikki.Phoenix();
                        System.Console.WriteLine($"\n{ikki}\n");
                        attackAndDefend.attackDefend(ikki);
                        break;

                    case "3":
                        seiya.Pegasus();
                        System.Console.WriteLine($"\n{seiya}\n");
                        attackAndDefend.attackDefend(seiya);
                        break;

                    case "4":
                        shiryu.Dragon();
                        System.Console.WriteLine($"\n{shiryu}\n");
                        attackAndDefend.attackDefend(shiryu);
                        break;

                    case "5":
                        shun.Andromeda();
                        System.Console.WriteLine($"\n{shun}\n");
                        attackAndDefend.attackDefend(shun);
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