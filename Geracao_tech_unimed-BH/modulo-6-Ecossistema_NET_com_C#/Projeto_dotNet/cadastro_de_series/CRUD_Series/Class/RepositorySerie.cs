using CRUD_Series.Interfeces;
using System.Collections.Generic;
using System;

namespace CRUD_Series
{
    public class RepositorySerie : IRepository<Serie>
    {
        private List<Serie> listSeries = new List<Serie>();
        public void Delete(int id)
        {
            listSeries[id].DeleteSerie();
        }

        public void Insert(Serie entity)
        {
            listSeries.Add(entity);
        }

        public List<Serie> List()
        {
            return listSeries;
        }

        public int NextId()
        {
            return listSeries.Count;
        }

        public Serie ReturnId(int id)
        {
            return listSeries[id];
        }

        public void Update(int id, Serie entity)
        {
            listSeries[id] = entity;
        }
    }
}