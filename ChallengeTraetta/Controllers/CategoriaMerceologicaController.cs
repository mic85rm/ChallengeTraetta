using Microsoft.AspNetCore.Mvc;

namespace ChallengeTraetta.Controllers
{
 
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using ChallengeTraetta.Context;
    using ChallengeTraetta.Models;


    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaMerceologicaController : ControllerBase
    {
      private CompanyContext _companyContext;

      public CategoriaMerceologicaController(CompanyContext companyContext)
      {
        _companyContext = companyContext;
      }

      // GET: api/<CategoriaMerceologicaController>
      [HttpGet]
      public IEnumerable<CategoriaMerceologica> Get()
      {
        return _companyContext.CategorieMerceologiche;
      }

      // GET api/<CategoriaMerceologicaController>/5
      [HttpGet("{id}")]
      public CategoriaMerceologica Get(int id)
      {
        return _companyContext.CategorieMerceologiche.FirstOrDefault(s => s.Id == id);
      }

      // POST api/<EmployeeController>
      [HttpPost]
      public void Post([FromBody] CategoriaMerceologica value)
      {
        _companyContext.CategorieMerceologiche.Add(value);
        _companyContext.SaveChanges();
      }

      // PUT api/<CategoriaMerceologicaController>/5
      [HttpPut("{id}")]
      public void Put(int id, [FromBody] CategoriaMerceologica value)
      {
        var CategoriaMerceologica = _companyContext.CategorieMerceologiche.FirstOrDefault(s => s.Id == id);
        if (CategoriaMerceologica != null)
        {
          _companyContext.Entry<CategoriaMerceologica>(CategoriaMerceologica).CurrentValues.SetValues(value);
          _companyContext.SaveChanges();
        }
      }

      // DELETE api/<CategoriaMerceologicaControllerr>/5
      [HttpDelete("{id}")]
      public void Delete(int id)
      {
        var student = _companyContext.CategorieMerceologiche.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
          _companyContext.CategorieMerceologiche.Remove(student);
          _companyContext.SaveChanges();
        }
      }
    }

  }


