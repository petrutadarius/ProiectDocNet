using BusinessLayer;
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
    public class ShowController:ControllerBase
    {
        private readonly IShowService showService;
        public ShowController(IShowService showService)
        {
            this.showService = showService;
        }
        [HttpGet("")]
        [Authorize(Roles = "Admin")]
        public List<ShowModel> Read()
        {
            var model = showService.Read();
            return model;
        }
        [HttpPost("")]
        [Authorize(Roles ="Admin")]
        public void Create(ShowModel showModel)
        {
            showService.Create(showModel);
        }
        [HttpDelete("")]
        [Authorize(Roles = ("Admin"))]
        public void Delete(int id)
        {
            showService.Delete(id);
        }
        [HttpPut("")]
        [Authorize(Roles = ("Admin"))]
        public void Update(ShowEntity showEntity, int id)
        {
            showService.Update(showEntity, id);
        }
    }
}
