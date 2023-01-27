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

namespace RestaurantSpotlight.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotlightsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SpotlightsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Spotlights
        [HttpGet]
        public async Task<IActionResult> GetSpotlights()
        {
            var Spotlights = await _unitOfWork.Spotlights.GetAll();
            return Ok(Spotlights);
        }

        // GET: api/Spotlights/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpotlight(int id)
        {
            var Spotlight = await _unitOfWork.Spotlights.Get(q => q.Id == id);

            if (Spotlight == null)
            {
                return NotFound();
            }

            return Ok(Spotlight);
        }

        // PUT: api/Spotlights/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpotlight(int id, Spotlight Spotlight)
        {
            if (id != Spotlight.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Spotlights.Update(Spotlight);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await SpotlightExists(id))
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

        // POST: api/Spotlights
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Spotlight>> PostSpotlight(Spotlight Spotlight)
        {
            await _unitOfWork.Spotlights.Insert(Spotlight);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetSpotlight", new { id = Spotlight.Id }, Spotlight);
        }

        // DELETE: api/Spotlights/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSpotlight(int id)
        {
            var Spotlight = await _unitOfWork.Spotlights.Get(q => q.Id == id);
            if (Spotlight == null)
            {
                return NotFound();
            }

            await _unitOfWork.Spotlights.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> SpotlightExists(int id)
        {
            var reseration = await _unitOfWork.Spotlights.Get(q => q.Id == id);
            return reseration != null;
        }
    }
}
