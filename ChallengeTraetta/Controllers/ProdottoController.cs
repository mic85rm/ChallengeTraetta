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
    public class ProdottoController : ControllerBase
    {
      private CompanyContext _companyContext;

      public ProdottoController(CompanyContext companyContext)
      {
        _companyContext = companyContext;
      }

      // GET: api/<ProdottoController>
      [HttpGet]
      public IEnumerable<Prodotto> Get()
      {
        return _companyContext.Prodotti;
      }

      // GET api/<ProdottoController>/5
      [HttpGet("{id}")]
      public Prodotto Get(int id)
      {
        return _companyContext.Prodotti.FirstOrDefault(s => s.Id == id);
      }

      // POST api/<EmployeeController>
      [HttpPost]
      public void Post([FromBody] Prodotto value)
      {
        _companyContext.Prodotti.Add(value);
        _companyContext.SaveChanges();
      }

      // PUT api/<ProdottoController>/5
      [HttpPut("{id}")]
      public void Put(int id, [FromBody] Prodotto value)
      {
        var Prodotto = _companyContext.Prodotti.FirstOrDefault(s => s.Id == id);
        if (Prodotto != null)
        {
          _companyContext.Entry<Prodotto>(Prodotto).CurrentValues.SetValues(value);
          _companyContext.SaveChanges();
        }
      }

      // DELETE api/<ProdottoControllerr>/5
      [HttpDelete("{id}")]
      public void Delete(int id)
      {
        var student = _companyContext.Prodotti.FirstOrDefault(s => s.Id == id);
        if (student != null)
        {
          _companyContext.Prodotti.Remove(student);
          _companyContext.SaveChanges();
        }
      }
    }

  }



