namespace SaintSeiya.Models.Characters.GoldenKnights
{
    public class MenuGoldenKnights
    {
        public void ChooseKnight()
        {
            Afrodite afrodite = new Afrodite();
            Aioria aioria = new Aioria();
            Aioros aioros = new Aioros();
            Aldebaram aldebaram = new Aldebaram();
            DeathMask deathMask = new DeathMask();
            Doko doko = new Doko();
            Kamus kamus = new Kamus();
            Miro miro = new Miro();
            Mu mu = new Mu();
            Saga saga = new Saga();
            Shaka shaka = new Shaka();
            Shura shura = new Shura();

            AttackDefend attackAndDefend = new AttackDefend();

            while (true)
            {
                System.Console.WriteLine(" Digite (1) para escolher Mú de Áries. ");
                System.Console.WriteLine(" Digite (2) para escolher Aldebaran de Touro. ");
                System.Console.WriteLine(" Digite (3) para escolher Saga de Gêmios. ");
                System.Console.WriteLine(" Digite (4) para escolher Máscara da Morte de Câncer. ");
                System.Console.WriteLine(" Digite (5) para escolher Aioria de Leão. ");
                System.Console.WriteLine(" Digite (6) para escolher Shaka de Virgem. ");
                System.Console.WriteLine(" Digite (7) para escolher Doko de Libra. ");
                System.Console.WriteLine(" Digite (8) para escolher Miro de Escorpião. ");
                System.Console.WriteLine(" Digite (9) para escolher Aioros de Sargitário. ");
                System.Console.WriteLine(" Digite (10) para escolher Shura de Capricórnio. ");
                System.Console.WriteLine(" Digite (11) para escolher Kamus de Aquáeio. ");
                System.Console.WriteLine(" Digite (12) para escolher Afordite de Peixes. ");
                System.Console.WriteLine(" Digite (0) para voltar ao menu principal. ");

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
                        System.Console.WriteLine($"\n{kamus}\n");
                        attackAndDefend.attackDefend(kamus);
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
                        System.Console.WriteLine($"\n{shaka}\n");
                        attackAndDefend.attackDefend(shaka);
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