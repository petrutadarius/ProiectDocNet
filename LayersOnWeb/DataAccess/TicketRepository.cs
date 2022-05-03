using DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TicketRepository : ITicketRepository
    {
        private readonly WeatherDbContext weatherDbContext;
        public TicketRepository(WeatherDbContext weatherDbContext)
        {
            this.weatherDbContext = weatherDbContext;
        }
        public void Create(TicketEntity ticket)
        {
            weatherDbContext.Add(ticket);
            weatherDbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            weatherDbContext.Remove(weatherDbContext.TicketEntities.First(s => s.Id == Id));
            weatherDbContext.SaveChanges();
        }

        public List<TicketEntity> Read()
        {
            return weatherDbContext.TicketEntities.ToList();
        }

        public void Update(TicketEntity ticketEntity, int Id)
        {
            var ticket = weatherDbContext.TicketEntities.Find(Id);
            ticket.Row = ticketEntity.Row;
            ticket.Column = ticketEntity.Column;
            ticket.Price = ticketEntity.Price;
            ticket.ShowTitle = ticketEntity.ShowTitle;
            weatherDbContext.SaveChanges();
        }
    }
}
