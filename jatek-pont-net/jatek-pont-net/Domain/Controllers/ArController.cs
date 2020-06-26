using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using jatek_pont_net.Domain.Models;
using jatek_pont_net.Domain.Repositories;
using jatek_pont_net.Persistence;
using jatek_pont_net.Persistence.Repositories;

namespace jatek_pont_net.Domain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Ar
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ar>>> GetAr()
        {
            return await _unitOfWork.ArRepository.GetAll();
        }

        // GET: api/Ar/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ar>> GetAr(int id)
        {
            var ar = await _unitOfWork.ArRepository.GetById(id);

            if (ar == null)
            {
                return NotFound();
            }

            return ar;
        }

        // PUT: api/Ar/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAr(int id, Ar ar)
        {
            if (id != ar.Id)
            {
                return BadRequest();
            }

            // edit here

            try
            {
                await _unitOfWork.Commit();
            }
            catch (DbUpdateConcurrencyException)
            {
                Ar selectedAr = await _unitOfWork.ArRepository.GetById(id);
                if (selectedAr == null)
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

        // POST: api/Ar
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ar>> PostAr(Ar ar)
        {
            Ar createdAr = await _unitOfWork.ArRepository.Add(ar);
            await _unitOfWork.Commit();

            return createdAr;
        }

        // DELETE: api/Ar/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ar>> DeleteAr(int id)
        {
            Ar ar = await _unitOfWork.ArRepository.GetById(id);
            if (ar == null)
            {
                return NotFound();
            }

            _unitOfWork.ArRepository.Remove(ar);
            await _unitOfWork.Commit();

            return ar;
        }
    }
}
