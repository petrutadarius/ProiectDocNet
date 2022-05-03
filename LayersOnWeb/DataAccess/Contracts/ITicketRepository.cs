using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface ITicketRepository
    {
        List<TicketEntity> Read();
        void Create(TicketEntity ticket);
        void Delete(int Id);
        void Update(TicketEntity ticketEntity, int Id);
    }
}
