namespace SaintSeiya.Models
{

    public class Knight
    {
        public string? Name;
        public string? Category;
        public string? Armor;
        public string? Attacks;
        public int LevelAttacks;
        public int LevelDefense;

        public Knight() {}

        public Knight(
            string Name,
            string Category,
            string Armor,
            string Attacks,
            int LevelAttacks,
            int LevelDefense)
        {
            this.Name = Name;
            this.Category = Category;
            this.Armor = Armor;
            this.Attacks = Attacks;
            this.LevelAttacks = LevelAttacks;
            this.LevelDefense = LevelDefense;
        }


        public override string ToString()
        {
            return $"\n - Nome: {this.Name}\n - Categoria: {this.Category}\n - Armadura: {this.Armor}\n - Ataque: {this.Attacks}\n - Nivel do Ataque: {this.LevelAttacks}\n - Nivel da Defesa: {this.LevelDefense}";
        }

        public virtual string LaunchAttack(){
            return $"\n - {this.Name} Ataca com {this.Attacks}\n";
        }


        public virtual string Defend(){
            return $" - {this.Name} se defendeu do golpe\n";
        }
    }


}