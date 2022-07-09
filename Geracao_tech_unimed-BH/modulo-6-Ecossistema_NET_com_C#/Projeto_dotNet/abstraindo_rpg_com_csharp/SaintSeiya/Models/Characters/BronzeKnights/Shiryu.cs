namespace SaintSeiya.Models.Characters.BronzeKnights
{
    public class Shiryu : Knight
    {
        public void Dragon(){
            this.Name = "Shiryu";
            this.Category = "Cavaleiro de Bronze";
            this.Armor = "Dragão";
            this.Attacks = "CÓLERA DO DRAGÃO...";
            this.LevelAttacks = 37;
            this.LevelDefense = 26;
        }

        public override string Defend(){
            return $" - {this.Name} se defendeu do golpe com o ESCUDO DO DRAGÃO\n";
        }
    }
}