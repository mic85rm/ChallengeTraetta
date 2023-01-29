using ChallengeTraetta.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ChallengeTraetta.Controllers
{
  using Microsoft.AspNetCore.Mvc;
  using System.Collections.Generic;
  using System.Linq;
  using ChallengeTraetta.Context;
  using ChallengeTraetta.Models;
  using Microsoft.EntityFrameworkCore;

  [Route("api/[controller]")]
  [ApiController]
  public class IndirizzoController : ControllerBase
  {
    private CompanyContext _companyContext;

    public IndirizzoController(CompanyContext companyContext)
    {
      _companyContext = companyContext;
    }

    // GET: api/<IndirizzoController>
    [HttpGet]
    public IEnumerable<Indirizzo> Get()
    {
      return _companyContext.Indirizzi.Include(b=>b.Compagnia);
    }

    // GET api/<IndirizzoController>/5
    [HttpGet("{id}")]
    public Indirizzo Get(int id)
    {
      return _companyContext.Indirizzi.FirstOrDefault(s => s.Id == id);
    }

    // POST api/<EmployeeController>
    [HttpPost]
    public void Post([FromBody] Indirizzo value)
    {
      _companyContext.Indirizzi.Add(value);
      _companyContext.SaveChanges();
    }

    // PUT api/<IndirizzoController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Indirizzo value)
    {
      var Indirizzo = _companyContext.Indirizzi.FirstOrDefault(s => s.Id == id);
      if (Indirizzo != null)
      {
        _companyContext.Entry<Indirizzo>(Indirizzo).CurrentValues.SetValues(value);
        _companyContext.SaveChanges();
      }
    }

    // DELETE api/<IndirizzoControllerr>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var student = _companyContext.Indirizzi.FirstOrDefault(s => s.Id == id);
      if (student != null)
      {
        _companyContext.Indirizzi.Remove(student);
        _companyContext.SaveChanges();
      }
    }
  }

}
