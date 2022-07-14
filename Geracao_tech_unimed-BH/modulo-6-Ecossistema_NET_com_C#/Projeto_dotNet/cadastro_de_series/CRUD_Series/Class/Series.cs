namespace CRUD_Series
{
    public class Series : BaseEntity
    {
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private string Age { get; set; }

        public Series(int id, Genre genre, string title, string descrition, string age)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = descrition;
            this.Age = age;
        }

        public override string ToString()
        {
            string result = "";
            result += $"Gênero: {this.Genre} {Environment.NewLine}";
            result += $"Titulo: {this.Title} {Environment.NewLine}";
            result += $"Descrição: {this.Description} {Environment.NewLine}";
            result += $"Lançamento: {this.Age}";

            return result;
        }


        public string ReturnTitle(){
            return this.Title;
        }

        public int ReturnId(){
            return this.Id;
        }
    }

}