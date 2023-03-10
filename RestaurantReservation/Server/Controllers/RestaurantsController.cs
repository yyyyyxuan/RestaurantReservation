using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Server.Data;
using RestaurantReservation.Server.IRepository;
using RestaurantReservation.Shared.Domain;

namespace RestaurantRestaurant.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public RestaurantsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Restaurants
        [HttpGet]
        public async Task<IActionResult> GetRestaurants()
        {
            var Restaurants = await _unitOfWork.Restaurants.GetAll();
            return Ok(Restaurants);
        }

        // GET: api/Restaurants/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRestaurant(int id)
        {
            var Restaurant = await _unitOfWork.Restaurants.Get(q => q.Id == id);

            if (Restaurant == null)
            {
                return NotFound();
            }

            return Ok(Restaurant);
        }

        // PUT: api/Restaurants/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRestaurant(int id, Restaurant Restaurant)
        {
            if (id != Restaurant.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Restaurants.Update(Restaurant);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await RestaurantExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Restaurants
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Restaurant>> PostRestaurant(Restaurant Restaurant)
        {
            await _unitOfWork.Restaurants.Insert(Restaurant);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetRestaurant", new { id = Restaurant.Id }, Restaurant);
        }

        // DELETE: api/Restaurants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestaurant(int id)
        {
            var Restaurant = await _unitOfWork.Restaurants.Get(q => q.Id == id);
            if (Restaurant == null)
            {
                return NotFound();
            }

            await _unitOfWork.Restaurants.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> RestaurantExists(int id)
        {
            var reseration = await _unitOfWork.Restaurants.Get(q => q.Id == id);
            return reseration != null;
        }
    }
}
