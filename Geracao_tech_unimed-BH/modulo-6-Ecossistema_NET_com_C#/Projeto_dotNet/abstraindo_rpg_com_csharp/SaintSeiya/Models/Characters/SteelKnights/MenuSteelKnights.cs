namespace SaintSeiya.Models.Characters.SteelKnights
{
    public class MenuSteelKnights
    {
        public void ChooseKnight(){
            Daichi daichi = new Daichi();
            Sho sho = new Sho();
            Ushio ushio = new Ushio();

            AttackDefend attackAndDefend = new AttackDefend();

            while(true){
                System.Console.WriteLine($"================ Cavaleiros de Aço ================");

                System.Console.WriteLine(" Digite (1) para escolher Daichi da Armadura da Terra. ");
                System.Console.WriteLine(" Digite (2) para escolher Daichi da Shô do Ar. ");
                System.Console.WriteLine(" Digite (3) para escolher Ushio da Armadura do Mar. ");
                System.Console.WriteLine(" Digite (0) para voltar ao menu principal. ");

                System.Console.WriteLine($"=======================================================");

                string? option = System.Console.ReadLine();

                switch (option)
                {
                    case "1":
                        daichi.EarthArmor();
                        System.Console.WriteLine($"\n{daichi}\n");

                        attackAndDefend.attackDefend(daichi);
                        break;

                    case "2":
                        sho.SkyArmor();
                        System.Console.WriteLine($"\n{sho}\n");
                        attackAndDefend.attackDefend(sho);
                        break;

                    case "3":
                        ushio.SeaArmor();
                        System.Console.WriteLine($"\n{ushio}\n");
                        attackAndDefend.attackDefend(ushio);
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