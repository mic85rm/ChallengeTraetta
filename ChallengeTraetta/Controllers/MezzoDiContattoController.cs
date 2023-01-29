using Microsoft.AspNetCore.Mvc;

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
    public class MezzoDiContattoController : ControllerBase
    {
      private CompanyContext _companyContext;

      public MezzoDiContattoController(CompanyContext companyContext)
      {
        _companyContext = companyContext;
      }

      // GET: api/<MezzoDiContattoController>
      [HttpGet]
      public IEnumerable<MezzoDiContatto> Get()
      {
        return _companyContext.MezziDiContatto.Include(c=>c.TipoContatto);
      }

      // GET api/<MezzoDiContattoController>/5
      [HttpGet("{id}")]
      public MezzoDiContatto Get(int id)
      {
        return _companyContext.MezziDiContatto.Include(b=>b.TipoContatto).FirstOrDefault(s => s.Id == id);
      }

      // POST api/<EmployeeController>
      [HttpPost]
      public void Post([FromBody] MezzoDiContatto value)
      {
        _companyContext.MezziDiContatto.Add(value);
        _companyContext.SaveChanges();
      }

      // PUT api/<MezzoDiContattoController>/5
      [HttpPut("{id}")]
      public void Put(int id, [FromBody] MezzoDiContatto value)
      {
        var MezzoDiContatto = _companyContext.MezziDiContatto.FirstOrDefault(s => s.Id == id);
        if (MezzoDiContatto != null)
        {
          _companyContext.Entry<MezzoDiContatto>(MezzoDiContatto).CurrentValues.SetValues(value);
          _companyContext.SaveChanges();
        }
      }

      // DELETE api/<MezzoDiContattoControllerr>/5
      [HttpDelete("{id}")]
      public void Delete(int id)
      {
        var student = _companyContext.MezziDiContatto.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
          _companyContext.MezziDiContatto.Remove(student);
          _companyContext.SaveChanges();
        }
      }
    }

  }


