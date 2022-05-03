using BusinessLayer.Contracts;
using DataAccess.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayersOnWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class TicketController:ControllerBase
    {
        private readonly ITicketService ticketService;
        private readonly IShowService showService;
        private readonly IShowMapper showMapper;
        private readonly ITicketMapper ticketMapper;
        public TicketController(ITicketService ticketService, IShowService showService, IShowMapper showMapper, ITicketMapper ticketMapper)
        {
            this.ticketService = ticketService;
            this.showService = showService;
            this.showMapper = showMapper;
            this.ticketMapper = ticketMapper;
        }
        [HttpGet("")]
        [Authorize(Roles = "Admin")]
        public List<TicketModel> Read()
        {
            var model = ticketService.Read();
            return model;
        }
        [HttpPost("")]
        [Authorize(Roles = "Admin")]
        public void Create(TicketModel ticketModel)
        {
            ticketService.Create(ticketModel);
        }
        [HttpDelete("")]
        [Authorize(Roles = ("Admin"))]
        public void Delete(int id)
        {
            ticketService.Delete(id);
        }
        [HttpPut("")]
        [Authorize(Roles = ("Admin"))]
        public void Update(TicketEntity ticketEntity, int id)
        {
            ticketService.Update(ticketEntity, id);
        }

        [HttpPut("SellTickets")]
        [Authorize(Roles = "Cashier")]
        public void SellTickets(string titleShow)
        {
            var resultShows = showService.Read();
            for (int i = 0; i < resultShows.Count(); i++)
            {
                if (resultShows[i].Title == titleShow)
                {
                    if (resultShows[i].NumberTickets > 0)
                    {
                        resultShows[i].NumberTickets -= 1;
                        showService.Update(showMapper.Map(resultShows[i]), resultShows[i].Id);
                        var result = ticketService.Read();
                        for (int j = 0; j < result.Count(); j++)
                        {
                            if (result[j].sell == false && result[i].ShowTitle == titleShow)
                            {
                                result[j].sell = true;
                                ticketService.Update(ticketMapper.Map(result[j]), result[j].Id);
                                break;
                            }
                        }
                        break;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
        }
    }
}
