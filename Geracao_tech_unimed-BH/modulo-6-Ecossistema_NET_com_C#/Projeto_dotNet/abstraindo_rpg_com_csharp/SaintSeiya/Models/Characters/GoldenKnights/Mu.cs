namespace SaintSeiya.Models.Characters.GoldenKnights
{
    public class Mu : Knight
    {
        public void Aries(){
            this.Name = "Mú";
            this.Category = "Cavaleiro de Ouro";
            this.Armor = "Áries";
            this.Attacks = "EXTINÃO ESTRELAR...";
            this.LevelAttacks = 83;
            this.LevelDefense = 81;
        }

        public override string Defend(){
            return $" - {this.Name} se defendeu do golpe com o PAREDE DE CRISTAL...\n";
        }
    }
}