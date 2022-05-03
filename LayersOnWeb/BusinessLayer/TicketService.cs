using BusinessLayer.Contracts;
using DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository ticketRepository;
        private readonly ITicketMapper ticketMapper;
        public TicketService(ITicketRepository ticketRepository, ITicketMapper ticketMapper)
        {
            this.ticketRepository = ticketRepository;
            this.ticketMapper = ticketMapper;
        }
        public void Create(TicketModel ticketModel)
        {
            var Ticket = ticketMapper.Map(ticketModel);
            ticketRepository.Create(Ticket);
        }

        public void Delete(int id)
        {
            ticketRepository.Delete(id);
        }

        public List<TicketModel> Read()
        {
            List<TicketEntity> tickets = ticketRepository.Read();
            List<TicketModel> models = new List<TicketModel>();
            if (tickets != null)
            {
                for (int i = 0; i < tickets.Count; i++)
                {
                    models.Add(ticketMapper.Map(tickets[i]));
                }
            }
            return models;
        }

        public void Update(TicketEntity ticket, int id)
        {
            ticketRepository.Update(ticket, id);
        }
    }
}
