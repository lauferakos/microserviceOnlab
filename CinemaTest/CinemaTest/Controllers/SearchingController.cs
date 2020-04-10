using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaTest.AggregatesModel.OrderAggregate;
using CinemaTest.AggregatesModel.ProjectionAggregate;
using CinemaTest.AggregatesModel.RoomAggregate;
using CinemaTest.AggregatesModel.ViewerAggregate;
using CinemaTest.Infrastructure;
using CinemaTest.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CinemaTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchingController : ControllerBase
    {
      

       // private readonly ILogger<SearchingController> _logger;

        
        private readonly IOrderRepository orderRepository;
        private readonly IProjectionRepository projectionRepository;
        private readonly IViewerRepository viewerRepository;
        private readonly IRoomRepository roomRepository;
        private readonly SearchingContext context;
        

        public SearchingController (
          SearchingContext _context, IProjectionRepository _projectionRepository, IOrderRepository _orderRepository, IViewerRepository _viewerRepository,
          IRoomRepository _roomRepository
          )
        {
            context = _context;
            projectionRepository = _projectionRepository;
            orderRepository = _orderRepository;
            viewerRepository = _viewerRepository;
            roomRepository = _roomRepository;
        }
       
      
        [HttpGet]
        [Route("Film/Find/{id}")]
        public async Task<Film> GetFilmById(int id)
        {
             return await projectionRepository.FindFilmByIdAsync(id);
        }


        //Async ? 
        [HttpGet]
        [Route("Film/List")]
        public IEnumerable<Film> GetAllFilm()
        {
             return projectionRepository.FindAllFilm();
        }

        [HttpGet]
        [Route("Film/List/{name}")]
        public async Task<Film> GetFilmByNameAsync(string name)
        {
            return await projectionRepository.GetFilmByNameAsync(name);
        }


        //Async ?
        [HttpGet]
        [Route("Projection/List")]
        public IEnumerable<Projection> GetAllProjection()
        {
           return projectionRepository.FindAllProjection();
        }

        [HttpGet]
        [Route("Projection/Find/{id}")]
        public async Task<Projection> GetProjectionById(int id)
        {
            return await projectionRepository.FindProjectionByIdAsync(id);
        }

        [HttpGet]
        [Route("Projection/List/Film/{id}")]
        public async Task<List<Projection>> GetAllProjectionByFilmId(int id)
        {
            return await projectionRepository.GetAllProjectionByFilmIdAsync(id);
        }

        [HttpGet]
        [Route("Seat/Find/{id}")]
        public async Task<Seat> GetSeatById(int id)
        {
            return await roomRepository.FindSeatByIdAsync(id);
        }

        [HttpGet]
        [Route("Seat/List/Room/{id}")]
        public async Task<List<Seat>> GetAllSeatByRoomIdAsync(int id)
        {
            return await roomRepository.GetAllSeatByRoomIdAsync(id);
        }

        [HttpGet]
        [Route("Room/Find/{id}")]
        public async Task<Room> GetRoomById(int id)
        {
           return await roomRepository.FindRoomByIdAsync(id);
        }

        [HttpGet]
        [Route("Viewer/Find/{id}")]
        public async Task<Viewer> GetViewerById(int id)
        {
            return await viewerRepository.FindViewerByIdAsync(id);
        }

        [HttpGet]
        [Route("Order/List/User/{id}")]
        public async Task<List<Order>> GetAllOrderByViewerIdAsync(int id)
        {
            return await orderRepository.GetAllOrderByViewerIdAsync(id);
        }

        [HttpGet]
        [Route("Order/Find/{id}")]
        public async Task<Order> GetOrderById(int id)
        {
            return await orderRepository.FindOrderByIdAsync(id);
        }
    }
}
