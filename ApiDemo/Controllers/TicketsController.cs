using ApiDemo.Models;
using ApiDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace ApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        [EnableQuery]
        [Route("all")]

        public List<Ticket> Get()
        {
            return TicketService.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public Ticket Get(int id)
        {
            Ticket t = TicketService.Get(id);
            return t;
        }
    }
}
