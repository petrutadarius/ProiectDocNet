using BusinessLayer.Contracts;
using DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ShowMapper : IShowMapper
    {
        public ShowModel Map(ShowEntity showentity)
        {
            ShowModel model = new ShowModel();
            model.Id = showentity.Id;
            model.Time = showentity.Time;
            model.Title = showentity.Title;
            model.Genre = showentity.Genre;
            model.NumberTickets = showentity.NumberTickets;
            return model;
        }

        public ShowEntity Map(ShowModel showmodel)
        {
            ShowEntity model = new ShowEntity();
            model.Id = showmodel.Id;
            model.Time = showmodel.Time;
            model.Title = showmodel.Title;
            model.Genre = showmodel.Genre;
            model.NumberTickets = showmodel.NumberTickets;
            return model;
        }
    }
}
