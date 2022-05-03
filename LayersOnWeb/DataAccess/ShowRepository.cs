using DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ShowRepository : IShowRepository
    {
        private readonly WeatherDbContext weatherDbContext;
        public ShowRepository(WeatherDbContext weatherDbContext)
        {
            this.weatherDbContext = weatherDbContext;
        }
        public void Create(ShowEntity show)
        {
            weatherDbContext.Add(show);
            weatherDbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            weatherDbContext.Remove(weatherDbContext.ShowEntities.First(s => s.Id == Id));
            weatherDbContext.SaveChanges();
        }

        public List<ShowEntity> Read()
        {
            return weatherDbContext.ShowEntities.ToList();
        }

        public void Update(ShowEntity showEntity, int Id)
        {
            var show = weatherDbContext.ShowEntities.Find(Id);
            show.Time = showEntity.Time;
            show.Title = showEntity.Title;
            show.Genre = showEntity.Genre;
            show.NumberTickets = showEntity.NumberTickets;
            weatherDbContext.SaveChanges();
        }
    }
}
