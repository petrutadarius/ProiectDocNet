using DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public interface ITicketService
    {
        List<TicketModel> Read();
        void Create(TicketModel ticketModel);
        void Delete(int id);
        void Update(TicketEntity ticket, int id);
    }
}
