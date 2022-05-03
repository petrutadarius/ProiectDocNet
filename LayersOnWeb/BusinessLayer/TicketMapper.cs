using BusinessLayer.Contracts;
using DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TicketMapper : ITicketMapper
    {
        public TicketModel Map(TicketEntity ticketentity)
        {
            TicketModel model = new TicketModel();
            model.Id = ticketentity.Id;
            model.Row = ticketentity.Row;
            model.Column = ticketentity.Column;
            model.Price = ticketentity.Price;
            model.ShowTitle = ticketentity.ShowTitle;
            model.sell = ticketentity.sell;
            return model;
        }

        public TicketEntity Map(TicketModel ticketmodel)
        {
            TicketEntity model = new TicketEntity();
            model.Id = ticketmodel.Id;
            model.Row = ticketmodel.Row;
            model.Column = ticketmodel.Column;
            model.Price = ticketmodel.Price;
            model.ShowTitle = ticketmodel.ShowTitle;
            model.sell = ticketmodel.sell;
            return model;
        }
    }
}
