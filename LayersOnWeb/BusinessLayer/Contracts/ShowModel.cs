using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public class ShowModel
    {
        public int Id { get; set; }
        public int Time { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int NumberTickets { get; set; }
    }
}
