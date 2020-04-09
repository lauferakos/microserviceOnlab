using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaTest.AggregatesModel.OrderAggregate;
using CinemaTest.AggregatesModel.ProjectionAggregate;
using CinemaTest.AggregatesModel.ViewerAggregate;
using CinemaTest.Infrastructure;
using CinemaTest.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CinemaTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchingController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<SearchingController> _logger;

        
        private readonly IOrderRepository orderRepository;
        private readonly IProjectionRepository projectionRepository;
        private readonly IViewerRepository viewerRepository;
        private readonly SearchingContext context;

        public SearchingController (
          SearchingContext _context)
        {
            context = _context;
        }
       
        /*[HttpGet]
        public async Task<ActionResult<Order>> GetOrderByIdAsync([FromQuery] int id)
        {
            var order = await orderRepository.FindByIdAsync(id);

            if(order == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(order);
            }

        }*/
        [HttpGet]
        public IEnumerable<Film> Get()
        {
            var rng = new Random();

            
            return Enumerable.Range(1, 5).Select(index => new Film
            {
                Id = 1,
                Title = "Cim",
                Description = "leiras",
                Duration = 20,
                Director ="Akos"
            })
            .ToArray();
        }
    }
}
