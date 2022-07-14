using CRUD_Series;

namespace CRUD_Series
{
    public class ListSeries
    {
        RepositorySerie repository = new RepositorySerie();
        public void List()
        {
            Console.WriteLine();
            Console.WriteLine("========= Sua lista de serie =========");
            Console.WriteLine();

            var list = repository.List();

            if (list.Count == 0)
            {
                Console.WriteLine("Nenhuma serie foi cadastrada. ");
                return; 
            }

            foreach (var serie in list)
            {
                Console.WriteLine($"ID: {serie.ReturnId()} - {serie.ReturnTitle()}");
            }
        }
    }
}