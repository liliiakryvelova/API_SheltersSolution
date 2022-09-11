using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Shelters.Models;
using System.Linq;

namespace Shelters.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ShelterDataController : ControllerBase
  {
    private readonly ShelterContext _db;

    public ShelterDataController(ShelterContext db)
    {
      _db = db;
    }

    // GET api/shelterdata
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ShelterData>>> Get([FromQuery] PaginationFilter filter)
    {
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
      var pagedData = await _db.ShelterData
                      .Skip((validFilter.PageNumber - 1)*validFilter.PageSize)
                      .Take(validFilter.PageSize)
                      .ToListAsync();
                      var totalRecords = await _db.ShelterData.CountAsync();
      return Ok(new PagedResponse<List<ShelterData>>(pagedData, validFilter.PageNumber, validFilter.PageSize));
    }

    //POST api/shelterdata
    [HttpPost]
    public async Task<ActionResult<ShelterData>> Post(ShelterData shelterdata)
    {
      _db.ShelterData.Add(shelterdata);
      await _db.SaveChangesAsync();

      return CreatedAtAction("Post", new { id = shelterdata.ShelterDataId}, shelterdata);
    }

    //GET api/shelterdata/2
    [HttpGet("{id}")]
    public async Task<ActionResult<ShelterData>> GetShelterData(int id)
    {
      var shelterdata = await _db.ShelterData.FindAsync(id);

      if(shelterdata == null)
      {
        return NotFound();
      }
      return Ok(new Response<ShelterData>(shelterdata));
    }

    //PUT api/shelterdata/6
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, ShelterData shelterdata)
    {
      if(id != shelterdata.ShelterDataId)
      {
        return BadRequest();
      }

      _db.Entry(shelterdata).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch(DbUpdateConcurrencyException)
      {
        if(!ShelterDataExists(id))
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

    private bool ShelterDataExists(int id)
    {
      return _db.ShelterData.Any(e => e.ShelterDataId == id);
    }

    //DELETE api/shelterdata/6
    [Authorize]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      var shelterdata = await _db.ShelterData.FindAsync(id);
      if(shelterdata == null)
      {
        return NotFound();
      }
      _db.ShelterData.Remove(shelterdata);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}