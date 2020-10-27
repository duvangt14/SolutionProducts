using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catalog.api.Context;
using catalog.api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace catalog.api.Controllers
{
  [Route("api/[controller]")]
  public class ProductController : Controller
  {

    private readonly AppDbContext _context;
    public ProductController(AppDbContext context)
    {
      this._context = context;
    }



    // GET: api/<controller>
    [HttpGet]
    public IQueryable<Product> Get()
    {
      
      return _context.Product;
    }

    // GET api/<controller>/5
    [HttpGet("{id}")]
    public Product Get(int id)
    {
      var product = _context.Product.FirstOrDefault(p => p.IdProducto == id);
      return product;
    }

    // POST api/<controller>
    [HttpPost]
    public ActionResult Post([FromBody]Product product)
    {
      try
      {
        _context.Product.Add(product);
        _context.SaveChanges();
        return Ok();
      } catch (Exception ex)
      {
        return BadRequest();
      }

    }

    // PUT api/<controller>/5
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody]Product product)
    {
      if (product.IdProducto == id)
      {
        _context.Entry(product).State = EntityState.Modified;
        _context.SaveChanges();
        return Ok();
      }
      else
      {
        return BadRequest();
      }

    }

    // DELETE api/<controller>/5
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      var product = _context.Product.FirstOrDefault(p => p.IdProducto == id);
      if (product != null)
      {
        _context.Product.Remove(product);
        _context.SaveChanges();
        return Ok();
      }
      else 
      {
        return BadRequest();
      }
    }
  }
}
