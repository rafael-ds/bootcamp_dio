namespace SaintSeiya.Models.Characters.SteelKnights
{
    public class Sho : Knight
    {
        public void SkyArmor(){            
            this.Name = "Shô";
            this.Category = "Cavaleiro de Aço";
            this.Armor = "Armadura do Ar";
            this.Attacks = "FURACÃO DE AÇO...";
            this.LevelAttacks = 12;
            this.LevelDefense = 10; 

        }


        public override string LaunchAttack(){
            return $"\n - {this.Name}, Daichi e Ushio atacam juntos formando o {this.Attacks}\n";
        }
    }
}