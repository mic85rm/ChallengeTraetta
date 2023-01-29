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
  using Microsoft.AspNetCore.Authorization;

  [Route("api/[controller]")]
  [ApiController]
  public class CompagniaController : ControllerBase
  {
    private CompanyContext _companyContext;

    public CompagniaController(CompanyContext companyContext)
    {
      _companyContext = companyContext;
    }

    // GET: api/<CompagniaController>
    [HttpGet]
    [Authorize(Policy = Policies.Admin)]
    public IEnumerable<Compagnia> Get()
    {
      return _companyContext.Compagnie;
    }

    // GET api/<CompagniaController>/5
    [HttpGet("{id}")]
    public Compagnia Get(int id)
    {
      return _companyContext.Compagnie.FirstOrDefault(s => s.Id == id);
    }

    // POST api/<EmployeeController>
    [HttpPost]
    public void Post([FromBody] Compagnia value)
    {
      _companyContext.Compagnie.Add(value);
      _companyContext.SaveChanges();
    }

    // PUT api/<CompagniaController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Compagnia value)
    {
      var compagnia = _companyContext.Compagnie.FirstOrDefault(s => s.Id == id);
      if (compagnia != null)
      {
        _companyContext.Entry<Compagnia>(compagnia).CurrentValues.SetValues(value);
        _companyContext.SaveChanges();
      }
    }

    // DELETE api/<CompagniaControllerr>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var student = _companyContext.Compagnie.FirstOrDefault(s => s.Id == id);
      if (student != null)
      {
        _companyContext.Compagnie.Remove(student);
        _companyContext.SaveChanges();
      }
    }
  }

}
