 
namespace SaintSeiya.Models.Characters.Soldiers
{   
    public class MenuSoldier
    {
        public void Option()
        {
            Soldiers soldier = new Soldiers();
            AttackDefend attackAndDefend = new AttackDefend();
            
            soldier.Soldier();
            System.Console.WriteLine($"\n{soldier}\n");

            attackAndDefend.attackDefend(soldier);
        }
    }
}