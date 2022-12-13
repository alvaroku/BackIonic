using BackIonic.Modelos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackIonic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private readonly ContextoDB contextoDB;
        public AlumnoController()
        {
            contextoDB = new ContextoDB();
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Alumno> Get()
        {
            return contextoDB.Alumnos.ToList();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post(Alumno a)
        {
            contextoDB.Alumnos.Add(a);
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
            Alumno a = contextoDB.Alumnos.Where(x => x.Id == id).FirstOrDefault();
            contextoDB.Alumnos.Remove(a);
            contextoDB.SaveChanges();
        }
    }
}
