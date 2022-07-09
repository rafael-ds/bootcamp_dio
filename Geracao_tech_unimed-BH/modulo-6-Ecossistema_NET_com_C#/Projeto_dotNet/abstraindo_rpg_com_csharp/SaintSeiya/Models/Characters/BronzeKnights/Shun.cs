namespace SaintSeiya.Models.Characters.BronzeKnights
{
    public class Shun : Knight
    {
        public void Andromeda(){
            this.Name = "Shun";
            this.Category = "Cavaleiro de Bronze";
            this.Armor = "Andrômeda";
            this.Attacks = "CORRENTES DE ANDRÔMEDA...";
            this.LevelAttacks = 32;
            this.LevelDefense = 18;
        }

        public override string Defend(){
            return $" - {this.Name} se defendeu do golpe com a CORRENTE CIRCUALAR...\n";
        }
    }
}