using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCrudSeries
{
    public class Serie : BaseEntity
    {
        private Genre Genre { get; set; }
		private string Title { get; set; }
		private string Description { get; set; }
		private int Age { get; set; }

        private bool Exclude { get; set; }

        public Serie(int id, Genre genre, string title, string descrition, int age)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = descrition;
            this.Age = age;
            this.Exclude = false;
        }

        public override string ToString()
        {
            string result = "";
            result += $"Gênero: {this.Genre} {Environment.NewLine}";
            result += $"Titulo: {this.Title} {Environment.NewLine}";
            result += $"Descrição: {this.Description} {Environment.NewLine}";
            result += $"Lançamento: {this.Age}";
            result += $"Excluido: {this.Exclude}";

            return result;
        }

        public string ReturnTitle()
        {
            return this.Title;
        }

        public int ReturnId()
        {
            return this.Id;
        }

        public void DeleteSerie()
        {
            this.Exclude = true;
        }
    }

    
}