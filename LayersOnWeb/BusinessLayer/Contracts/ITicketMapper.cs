﻿using DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public interface ITicketMapper
    {
        public TicketModel Map(TicketEntity ticketentity);
        public TicketEntity Map(TicketModel ticketmodel);
    }
}
