namespace SaintSeiya.Models.Characters.GoldenKnights
{
    public class MenuGoldenKnights
    {
        public void ChooseKnight()
        {
            Mu mu = new Mu();
            Aldebaram aldebaram = new Aldebaram();
            Saga saga = new Saga();
            DeathMask deathMask = new DeathMask();
            Aioria aioria = new Aioria();
            Shaka shaka = new Shaka();
            Doko doko = new Doko();
            Aioros aioros = new Aioros();
            Miro miro = new Miro();
            Kamus kamus = new Kamus();
            Shura shura = new Shura();
            Afrodite afrodite = new Afrodite();

            mu.Aries();
            aldebaram.Taurus();
            saga.Gemini();
            deathMask.Cancer();
            aioria.Leo();
            shaka.Virgo();
            doko.Libra();
            aioros.Sargittarus();
            miro.Scorpion();
            kamus.Aquarius();
            shura.Capricorn();
            afrodite.Pisces();         
            
            AttackDefend attackAndDefend = new AttackDefend();

            while (true)
            {
                System.Console.WriteLine($" Digite (1) para escolher {mu.Name} de {mu.Armor}. ");
                System.Console.WriteLine($" Digite (2) para escolher {aldebaram.Name} de {aldebaram.Armor}. ");
                System.Console.WriteLine($" Digite (3) para escolher {saga.Name} de {saga.Armor}. ");
                System.Console.WriteLine($" Digite (4) para escolher {deathMask.Name} da {deathMask.Armor}. ");
                System.Console.WriteLine($" Digite (5) para escolher {aioria.Name} de {aioria.Armor}. ");
                System.Console.WriteLine($" Digite (6) para escolher {shaka.Name} de {shaka.Armor}. ");
                System.Console.WriteLine($" Digite (7) para escolher {doko.Name} de {doko.Armor}. ");
                System.Console.WriteLine($" Digite (8) para escolher {miro.Name} de {miro.Armor}. ");
                System.Console.WriteLine($" Digite (9) para escolher {aioros.Name} de {aioros.Armor}. ");
                System.Console.WriteLine($" Digite (10) para escolher {shura.Name} de {shura.Armor}. ");
                System.Console.WriteLine($" Digite (11) para escolher {kamus.Name} de {kamus.Aquarius}. ");
                System.Console.WriteLine($" Digite (12) para escolher {afrodite.Name} de {afrodite.Armor}. ");
                System.Console.WriteLine($" Digite (0) para voltar ao menu principal. ");

                System.Console.WriteLine($"=======================================================");

                string? option = System.Console.ReadLine();

                switch (option)
                {
                    case "1":
                        mu.Aries();
                        System.Console.WriteLine($"\n{mu}\n");

                        attackAndDefend.attackDefend(mu);
                        break;

                    case "2":
                        aldebaram.Taurus();
                        System.Console.WriteLine($"\n{aldebaram}\n");
                        attackAndDefend.attackDefend(aldebaram);
                        break;

                    case "3":
                        saga.Gemini();
                        System.Console.WriteLine($"\n{saga}\n");
                        attackAndDefend.attackDefend(saga);
                        break;

                    case "4":
                        deathMask.Cancer();
                        System.Console.WriteLine($"\n{deathMask}\n");
                        attackAndDefend.attackDefend(deathMask);
                        break;

                    case "5":
                        aioria.Leo();
                        System.Console.WriteLine($"\n{aioria}\n");
                        attackAndDefend.attackDefend(aioria);
                        break;

                    case "6":
                        shaka.Virgo();
                        System.Console.WriteLine($"\n{shaka}\n");
                        attackAndDefend.attackDefend(shaka);
                        break;

                    case "7":
                        doko.Libra();
                        System.Console.WriteLine($"\n{doko}\n");
                        attackAndDefend.attackDefend(doko);
                        break;

                    case "8":
                        miro.Scorpion();
                        System.Console.WriteLine($"\n{miro}\n");
                        attackAndDefend.attackDefend(miro);
                        break;

                    case "9":
                        aioros.Sargittarus();
                        System.Console.WriteLine($"\n{aioros}\n");
                        attackAndDefend.attackDefend(aioros);
                        break;

                    case "10":
                        shura.Capricorn();
                        System.Console.WriteLine($"\n{shura}\n");
                        attackAndDefend.attackDefend(shura);
                        break;

                    case "11":
                        kamus.Aquarius();
                        System.Console.WriteLine($"\n{kamus}\n");
                        attackAndDefend.attackDefend(kamus);
                        break;

                    case "12":
                        afrodite.Pisces();
                        System.Console.WriteLine($"\n{afrodite}\n");
                        attackAndDefend.attackDefend(afrodite);
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