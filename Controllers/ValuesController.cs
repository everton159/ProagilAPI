using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proagil.API.Data;
using Proagil.API.Model;

namespace Proagil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private DataContext _context { get; }

        public ValuesController(DataContext context)
        {
            this._context = context;


        }





        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _context.Eventos.ToListAsync();


                return Ok(results);    
            }
            catch (System.Exception)
            {
                
                return this.StatusCode(StatusCodes.Status404NotFound,"Não achamos essa parada");
            }
            
        }

        // GET api/values

        /*
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var results =_context.Eventos.ToList();

                return Ok(results);    
            }
            catch (System.Exception)
            {
                
                return this.StatusCode(StatusCodes.Status404NotFound,"Não achamos essa parada");
            }
            
        }
*/
        // GET api/values/5
        // [HttpGet("{id}")]
        // public ActionResult<Evento> Get(int id)
        // {
        //     return _context.Eventos.Find(id);
        // }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            
            try
            {
                var result= await _context.Eventos.FirstOrDefaultAsync(x=> x.EventoId==id);
                return Ok(result);    
            }
            catch (System.Exception)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Elemento não encontrado");
            }
            




        }


        

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
