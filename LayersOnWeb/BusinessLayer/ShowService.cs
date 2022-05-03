using BusinessLayer.Contracts;
using DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ShowService : IShowService
    {
        private readonly IShowRepository showRepository;
        private readonly IShowMapper showMapper;
        public ShowService(IShowRepository showRepository,IShowMapper showMapper)
        {
            this.showRepository = showRepository;
            this.showMapper = showMapper;
        }
        public void Create(ShowModel showModel)
        {
            var Show = showMapper.Map(showModel);
            showRepository.Create(Show);
        }

        public void Delete(int id)
        {
            showRepository.Delete(id);
        }

        public List<ShowModel> Read()
        {
            List<ShowEntity> shows = showRepository.Read();
            List<ShowModel> models = new List<ShowModel>();
            if (shows != null)
            {
                for (int i = 0; i < shows.Count; i++)
                {
                    models.Add(showMapper.Map(shows[i]));
                }
            }
            return models;
        }

        public void Update(ShowEntity show, int id)
        {
            showRepository.Update(show, id);
        }
    }
}
