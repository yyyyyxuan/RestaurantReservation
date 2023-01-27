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

namespace RestaurantReservation.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotlightItemsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SpotlightItemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/SpotlightItems
        [HttpGet]
        public async Task<IActionResult> GetSpotlightItems()
        {
            var SpotlightItems = await _unitOfWork.SpotlightItems.GetAll();
            return Ok(SpotlightItems);
        }

        // GET: api/SpotlightItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpotlightItem(int id)
        {
            var SpotlightItem = await _unitOfWork.SpotlightItems.Get(q => q.Id == id);

            if (SpotlightItem == null)
            {
                return NotFound();
            }

            return Ok(SpotlightItem);
        }

        // PUT: api/SpotlightItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpotlightItem(int id, SpotlightItem SpotlightItem)
        {
            if (id != SpotlightItem.Id)
            {
                return BadRequest();
            }

            _unitOfWork.SpotlightItems.Update(SpotlightItem);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await SpotlightItemExists(id))
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

        // POST: api/SpotlightItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SpotlightItem>> PostSpotlightItem(SpotlightItem SpotlightItem)
        {
            await _unitOfWork.SpotlightItems.Insert(SpotlightItem);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetSpotlightItem", new { id = SpotlightItem.Id }, SpotlightItem);
        }

        // DELETE: api/SpotlightItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSpotlightItem(int id)
        {
            var SpotlightItem = await _unitOfWork.SpotlightItems.Get(q => q.Id == id);
            if (SpotlightItem == null)
            {
                return NotFound();
            }

            await _unitOfWork.SpotlightItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> SpotlightItemExists(int id)
        {
            var reseration = await _unitOfWork.SpotlightItems.Get(q => q.Id == id);
            return reseration != null;
        }
    }
}
