namespace SaintSeiya.Models.Characters.SteelKnights
{
    public class Daichi : Knight
    {
        public void EarthArmor(){            
            this.Name = "Daichi";
            this.Category = "Cavaleiro de Aço";
            this.Armor = "Armadura da Terra";
            this.Attacks = "Furacão de Aço";
            this.LevelAttacks = 12;
            this.LevelDefense = 10; 

        }

        public override string LaunchAttack(){
            return $"\n - {this.Name}, Shô e Ushio atacam juntos formando o {this.Attacks}\n";
        }
    }
}