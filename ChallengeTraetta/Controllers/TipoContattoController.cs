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
    public class TipoContattoController : ControllerBase
    {
      private CompanyContext _companyContext;

      public TipoContattoController(CompanyContext companyContext)
      {
        _companyContext = companyContext;
      }

      // GET: api/<TipoContattoController>
      [HttpGet]
      public IEnumerable<TipoContatto> Get()
      {
        return _companyContext.TipiContatto;
      }

      // GET api/<TipoContattoController>/5
      [HttpGet("{id}")]
      public TipoContatto Get(int id)
      {
        return _companyContext.TipiContatto.FirstOrDefault(s => s.Id == id);
      }

      // POST api/<EmployeeController>
      [HttpPost]
      public void Post([FromBody] TipoContatto value)
      {
        _companyContext.TipiContatto.Add(value);
        _companyContext.SaveChanges();
      }

      // PUT api/<TipoContattoController>/5
      [HttpPut("{id}")]
      public void Put(int id, [FromBody] TipoContatto value)
      {
        var TipoContatto = _companyContext.TipiContatto.FirstOrDefault(s => s.Id == id);
        if (TipoContatto != null)
        {
          _companyContext.Entry<TipoContatto>(TipoContatto).CurrentValues.SetValues(value);
          _companyContext.SaveChanges();
        }
      }

      // DELETE api/<TipoContattoControllerr>/5
      [HttpDelete("{id}")]
      public void Delete(int id)
      {
        var student = _companyContext.TipiContatto.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
          _companyContext.TipiContatto.Remove(student);
          _companyContext.SaveChanges();
        }
      }
    }

  }



