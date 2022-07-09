using SaintSeiya.Models;
using SaintSeiya.Models.Characters.BronzeKnights;
using SaintSeiya.Models.Characters.Soldiers;

Seiya seiya = new Seiya();
Hyoga hyoga = new Hyoga();
Shiryu shiryu = new Shiryu();
Ikki ikki = new Ikki();
Shun shun = new Shun();

seiya.Pegasus();
hyoga.Swan();
shiryu.Dragon();
ikki.Fenix();
shun.Andromeda();


System.Console.WriteLine(seiya);
System.Console.WriteLine(seiya.LaunchAttack());
System.Console.WriteLine(seiya.Defend());

System.Console.WriteLine(hyoga);
System.Console.WriteLine(hyoga.LaunchAttack());
System.Console.WriteLine(hyoga.Defend());

System.Console.WriteLine(ikki);
System.Console.WriteLine(ikki.LaunchAttack());
System.Console.WriteLine(ikki.Defend());

System.Console.WriteLine(shiryu);
System.Console.WriteLine(shiryu.LaunchAttack());
System.Console.WriteLine(shiryu.Defend());

System.Console.WriteLine(shun);
System.Console.WriteLine(shun.LaunchAttack());
System.Console.WriteLine(shun.Defend());


Soldiers soldiers = new Soldiers();
soldiers.Soldier();
System.Console.WriteLine(soldiers);
System.Console.WriteLine(soldiers.LaunchAttack());
System.Console.WriteLine(soldiers.Defend());
