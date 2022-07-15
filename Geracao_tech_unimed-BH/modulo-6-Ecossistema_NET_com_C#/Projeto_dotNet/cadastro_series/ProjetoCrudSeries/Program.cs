﻿using System;

namespace ProjetoCrudSeries
{
    class Program
    {
        static RepositorySerie repository = new RepositorySerie();

        static void Main(string[] args)
        {
            string userOption = Menu();

			while (userOption.ToUpper() != "X")
			{
				switch (userOption)
				{
					case "1":
						ListSeries();
						break;

					case "2":
						InsertSerie();
						break;

					case "3":
                        UpedateSerie();
						break;

					case "4":
						break;

					case "5":
						break;

					case "C":
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				userOption = Menu();
			}
			Console.ReadLine();
        }

        private static void ListSeries()
		{
			Console.WriteLine("Listar séries");

			var list = repository.List();

			if (list.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				return;
			}

			foreach (var serie in list)
			{                
				Console.WriteLine("#ID {0}: - {1}", serie.ReturnId(), serie.ReturnTitle());
			}
		}

        private static void InsertSerie(){
            Console.WriteLine(" Inserir nova série");

            foreach (int item in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine(" {0} - {1}", item, Enum.GetName(typeof(Genre), item));
                // Console.WriteLine();
            }

            Console.WriteLine(" Digite o gênero apartir da opções informada acima: ");
            int enterGenre = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o titulo da serie: ");
            string enterTitle = Console.ReadLine();

            Console.WriteLine(" Digite o ano de lançamento da serie: ");
            int enterAge = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite a descrição da serie: ");
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

        private static void UpedateSerie(){
            Console.WriteLine("Informe o Id da serie: ");
            int indiceSerie = int.Parse(Console.ReadLine());


            foreach (int item in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine(" {0} - {1}", item, Enum.GetName(typeof(Genre), item));
                // Console.WriteLine();
            }

            Console.WriteLine(" Digite o gênero apartir da opções informada acima: ");
            int enterGenre = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o titulo da serie: ");
            string enterTitle = Console.ReadLine();

            Console.WriteLine(" Digite o ano de lançamento da serie: ");
            int enterAge = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite a descrição da serie: ");
            string enterDescription = Console.ReadLine();

            Serie updateSerie = new Serie(
                                        id: indiceSerie,
                                        genre: (Genre)enterGenre,
                                        title: enterTitle,
                                        age: enterAge,
                                        descrition: enterDescription
            );
            repository.Update(indiceSerie, updateSerie);
        }

         private static string Menu()
		{
			Console.WriteLine();
			Console.WriteLine(" Super Serie Crud ");
			Console.WriteLine(" Digite a opção desejada: ");

			Console.WriteLine(" 1- Listar séries "); 
			Console.WriteLine(" 2- Inserir nova série ");
			Console.WriteLine(" 3- Atualizar série ");
			Console.WriteLine(" 4- Excluir série ");
			Console.WriteLine(" 5- Visualizar série ");
			Console.WriteLine(" C- Limpar Tela ");
			Console.WriteLine(" X- Sair");
			Console.WriteLine();

			string userOption = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return userOption;
		}
    }
}
