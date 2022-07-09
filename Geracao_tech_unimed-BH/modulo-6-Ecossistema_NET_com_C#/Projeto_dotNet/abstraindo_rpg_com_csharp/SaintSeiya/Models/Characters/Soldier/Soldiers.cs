namespace SaintSeiya.Models.Characters.Soldiers
{
    public class Soldiers : Knight
    {
        public void Soldier(){
            this.Name = "Soldado";
            this.Category = "Soldado";
            this.Armor = "Basico";
            this.Attacks = "Lanças";
            this.LevelAttacks = 3;
            this.LevelDefense = 7;
        }
    }
}
