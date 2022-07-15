using System;

namespace CRUD_Series
{
    public class InsertSeries
    {
        RepositorySerie repository = new RepositorySerie();

        public void Insert()
        {
            Console.WriteLine();
            Console.WriteLine("========= Insira uma nova serie na sua lista =========");
            Console.WriteLine();



            foreach (int item in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0} - {1}", item, Enum.GetName(typeof(Genre), item));
                Console.WriteLine();
            }

            Console.WriteLine("Digite o gênero apartir da opções informada acima: ");
            int enterGenre = int.Parse("2");

            Console.WriteLine("Digite o titulo da serie: ");
            string enterTitle = Console.ReadLine();

            Console.WriteLine("Digite o ano de lançamento da serie: ");
            int enterAge = int.Parse("Console.ReadLine()");

            Console.WriteLine("Digite a descrição da serie: ");
            string enterDescription = Console.ReadLine();

            Serie newSerie = new Serie(
                id: repository.NextId(),
                genre: (Genre)enterGenre,
                title: enterTitle,
                age: enterAge,
                descrition: enterDescription

            );
            repository.Insert(newSerie);

        }
    }
}