using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WindowsWebApp.AggregatesModel.OrderAggregate;
using WindowsWebApp.AggregatesModel.ProjectionAggregate;
using WindowsWebApp.AggregatesModel.ViewerAggregate;
using WindowsWebApp.Infractructure;

namespace WindowsWebApp.Controllers
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
        private readonly SearchingContext searchingContext;

        public SearchingController(
          SearchingContext _searchingContext,IOrderRepository _orderRepository, IProjectionRepository _projectionRepository, IViewerRepository _viewerRepository)
        {
            searchingContext = _searchingContext;
            orderRepository = _orderRepository;
            projectionRepository = _projectionRepository;
            viewerRepository = _viewerRepository;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Projection>> GetOrderByIdAsync(int id)
        {
            //var projection = await projectionRepository.FindByIdAsync(id);

            var projection = await searchingContext.Projections.Where(p => p.Id == id).SingleOrDefaultAsync();

            if (projection == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(projection);
            }

        }
        [HttpPut]
        [Route("searching/update/projection/{id}")]
        public void updateProjectionById(int id)
        {

        }

        [HttpDelete]
        [Route("searching/delete/projection/{id}")]
        public void deleteProjectionById(int id)
        {

        }

        [HttpPost]
        [Route("searching/add/projection")]
        public void addProjection()
        {
        }



    }
}

