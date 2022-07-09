namespace SaintSeiya.Models
{
    public class Teste : Knight
    {   

        public void Seiya(){
            
            this.Name = "Seiya";
            this.Category = "Cavaleiro de Bronze";
            this.Armor = "Pegasus";
            this.Attacks = "Meteoro de Pegasus";
            this.LevelAttacks = 28;
            this.LevelDefense = 15; 

        }

        public string LaunchAttack(){
            return "\n - Seiya Ataca com um Meteoro de Pegasus\n";
        }


        public string Defend(){
            return $" - Seiya Defende-se do golpe\n";
        }
    }
}