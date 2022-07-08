namespace SaintSeiya.Models
{

    public class Knight
    {

        public Knight(
            string Name,
            string Category,
            string Armor,
            string Attacks,
            int LevelAttacks,
            int LevelDefense
            )
        {
            this.Name = Name;
            this.Category = Category;
            this.Armor = Armor;
            this.Attacks = Attacks;
            this.LevelAttacks = LevelAttacks;
            this.LevelDefense = LevelDefense;

        }

        public string Name;
        public string Category;
        public string Armor;
        public string Attacks;
        public int LevelAttacks;
        public int LevelDefense;


        public override string ToString()
        {
            return $"\n - Nome: {this.Name}\n - Categoria: {this.Category}\n - Armadura: {this.Armor}\n - Ataque: {this.Attacks}\n - Nivel do Ataque: {this.LevelAttacks}\n - Nivel da Defesa: {this.LevelDefense}";
        }
    }
}