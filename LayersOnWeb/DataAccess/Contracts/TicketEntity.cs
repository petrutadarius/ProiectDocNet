using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public class TicketEntity
    {
        public int Id { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public float Price { get; set; }
        public string ShowTitle { get; set; }
        public bool sell { get; set; }
    }
}
