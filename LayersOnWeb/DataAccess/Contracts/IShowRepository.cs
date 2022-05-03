using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IShowRepository
    {
        List<ShowEntity> Read();
        void Create(ShowEntity show);
        void Delete(int Id);
        void Update(ShowEntity showEntity, int Id);

    }
}
