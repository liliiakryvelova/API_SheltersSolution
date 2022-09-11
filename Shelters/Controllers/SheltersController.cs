using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shelters.Models;
using System.Linq;

namespace Shelters.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SheltersController : ControllerBase
  {
    private readonly ShelterContext _db;

    public SheltersController(ShelterContext db)
    {
      _db = db;
    }

    //GET api/shelters
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Shelter>>> Get()
    {
      return await _db.Shelters.ToListAsync();
    }

    //GET api/shelters
    [HttpPost]
    public async Task<ActionResult<Shelter>> Post(Shelter shelter)
    {
      _db.Shelters.Add(shelter);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = shelter.ShelterId }, shelter);
    }

    //GET api/shelters/4
    [HttpGet("{id}")]
    public async Task<ActionResult<Shelter>> GetShelter(int id)
    {
      var shelter = await _db.Shelters.FindAsync(id);
      if(shelter == null)
      {
        return NotFound();
      }
      return shelter;
    }

    //PUT api/shelters/7
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Shelter shelter)
    {
      if(id != shelter.ShelterId)
      {
        return BadRequest();
      }

      _db.Entry(shelter).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch(DbUpdateConcurrencyException)
      {
        if(!ShelterExists(id))
        {
          return NotFound();
        }else{
          throw;
        }
      }

      return NoContent();
    }

    private bool ShelterExists(int id)
    {
      return _db.Shelters.Any(e => e.ShelterId == id); 
    }

    //DELETE api/shelters/7
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      var shelter = await _db.Shelters.FindAsync(id);
      if(shelter == null)
      {
        return NotFound();
      }

      _db.Shelters.Remove(shelter);
      await _db.SaveChangesAsync();

      return NoContent();
    } 
    
  }
}