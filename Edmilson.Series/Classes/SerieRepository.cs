using System;
using System.Collections.Generic;
using Edmilson.Series.Interfaces;

namespace Edmilson.Series
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> serieList = new List<Serie>();
        public void Update(int id, Serie obj)
        {
            serieList[id] = obj;
        }

        public void Delete(int id)
        {
            serieList[id].Delete();
        }

        public void Insert(Serie obj)
        {
            serieList.Add(obj);
        }

        public List<Serie> List()
        {
            return serieList;
        }

        public int NextId()
        {
            return serieList.Count;
        }

        public Serie ReturnById(int id)
        {
            return serieList[id];
        }
    }
}