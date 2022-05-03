using DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public interface IShowService
    {
        List<ShowModel> Read();
        void Create(ShowModel showModel);
        void Delete(int id);
        void Update(ShowEntity show, int id);
    }
}
