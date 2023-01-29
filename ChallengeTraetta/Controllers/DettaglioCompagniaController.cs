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
    public class DettaglioCompagniaController : ControllerBase
    {
      private CompanyContext _companyContext;

      public DettaglioCompagniaController(CompanyContext companyContext)
      {
        _companyContext = companyContext;
      }

      // GET: api/<DettaglioCompagniaController>
      //[HttpGet]
      //public IEnumerable<DettaglioCompagnia> Get()
      //{
      //  return _companyContext..Include(b=> b.);
      //}

      //// GET api/<DettaglioCompagniaController>/5
      //[HttpGet("{id}")]
      //public DettaglioCompagnia Get(int id)
      //{
      //  return _companyContext.Compagnie.FirstOrDefault(s => s.Id == id);
      //}

      //// POST api/<EmployeeController>
      //[HttpPost]
      //public void Post([FromBody] DettaglioCompagnia value)
      //{
      //  _companyContext.Compagnie.Add(value);
      //  _companyContext.SaveChanges();
      //}

      //// PUT api/<DettaglioCompagniaController>/5
      //[HttpPut("{id}")]
      //public void Put(int id, [FromBody] DettaglioCompagnia value)
      //{
      //  var DettaglioCompagnia = _companyContext.Compagnie.FirstOrDefault(s => s.Id == id);
      //  if (DettaglioCompagnia != null)
      //  {
      //    _companyContext.Entry<DettaglioCompagnia>(DettaglioCompagnia).CurrentValues.SetValues(value);
      //    _companyContext.SaveChanges();
      //  }
      //}

      //// DELETE api/<DettaglioCompagniaControllerr>/5
      //[HttpDelete("{id}")]
      //public void Delete(int id)
      //{
      //  var student = _companyContext.Compagnie.FirstOrDefault(s => s.Id == id);
      //  if (student != null)
      //  {
      //    _companyContext.Compagnie.Remove(student);
      //    _companyContext.SaveChanges();
      //  }
      //}
    }

  }

