using BackIonic.Modelos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackIonic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActividadController : ControllerBase
    {
        private readonly ContextoDB contextoDB;
        public ActividadController()
        {
            contextoDB = new ContextoDB();
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Actividad> Get()
        {
            return contextoDB.Actividades.ToList();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post(Actividad a)
        {
            contextoDB.Actividades.Add(a);
            contextoDB.SaveChanges();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Actividad a = contextoDB.Actividades.Where(x=>x.Id == id).FirstOrDefault();
            contextoDB.Actividades.Remove(a);
            contextoDB.SaveChanges();
        }
    }
}
