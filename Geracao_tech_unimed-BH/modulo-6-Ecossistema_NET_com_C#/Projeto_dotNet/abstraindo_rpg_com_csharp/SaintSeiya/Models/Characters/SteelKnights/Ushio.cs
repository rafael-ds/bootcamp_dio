namespace SaintSeiya.Models.Characters.SteelKnights
{
    public class Ushio : Knight
    {
        public void SeaArmor(){            
            this.Name = "Ushio";
            this.Category = "Cavaleiro de Aço";
            this.Armor = "Armadura do Mar";
            this.Attacks = "Furacão de Aço";
            this.LevelAttacks = 12;
            this.LevelDefense = 10; 

        }

        public override string LaunchAttack(){
            return $"\n - {this.Name}, Daichi e Shô atacam juntos formando o {this.Attacks}\n";
        }
    }
}