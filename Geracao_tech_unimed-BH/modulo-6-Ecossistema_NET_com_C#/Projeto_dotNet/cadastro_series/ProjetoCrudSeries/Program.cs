using System;

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
                        DeleteSerie();
						break;

					case "5":
                        ViewSerie();
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
			Console.WriteLine(" ===================== Listar séries ======================== ");
			Console.WriteLine();

			var list = repository.List();

			if (list.Count == 0)
			{
				Console.WriteLine(" Ops! Nenhuma série cadastrada.");
				return;
			}

			foreach (var serie in list)
			{   
                var exclude = serie.ReturnExclude();  

                Console.WriteLine(" #ID {0}: - {1} {2}", serie.ReturnId(), serie.ReturnTitle(), (exclude ? "*Excluido*" : ""));         
			}
		}

        private static void InsertSerie(){
            Console.WriteLine(" ===================== Inserir nova séries ======================== ");

            Console.WriteLine(" ** Categotias ** ");
            foreach (int item in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine(" {0} - {1}", item, Enum.GetName(typeof(Genre), item));
            }
            Console.WriteLine();

            Console.WriteLine(" Digite a categoria apartir da opções informada acima: ");
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
            Console.WriteLine(" ===================== Atualizar uma séries ======================== ");

            Console.WriteLine(" **Informe o Id da serie: **");
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

        private static void DeleteSerie(){
            Console.WriteLine(" ===================== Deletar uma séries ======================== ");

            Console.WriteLine(" **Digite o Id da série: ** ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repository.Delete(indiceSerie);
        }


        private static void ViewSerie(){
            Console.WriteLine(" ===================== Informações da série ======================== ");

            Console.WriteLine(" **Digite o Id da série : ** ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repository.ReturnId(indiceSerie);

            Console.WriteLine(serie);
        }

         private static string Menu()
		{
			Console.WriteLine();
			Console.WriteLine(" ===================== Super Serie Crud ======================== ");
			Console.WriteLine(" Digite a opção desejada: ");
			Console.WriteLine();

			Console.WriteLine(" 1- Listar séries "); 
			Console.WriteLine(" 2- Inserir nova série ");
			Console.WriteLine(" 3- Atualizar série ");
			Console.WriteLine(" 4- Excluir série ");
			Console.WriteLine(" 5- Visualizar série ");
			Console.WriteLine(" C- Limpar Tela ");
			Console.WriteLine(" X- Sair");
			Console.WriteLine(" ================================================================= ");
			Console.WriteLine();

			string userOption = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return userOption;
		}
    }
}
