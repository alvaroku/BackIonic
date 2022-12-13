using BackIonic.Modelos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackIonic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActividadAlumnoController : ControllerBase
    {
        private readonly ContextoDB contextoDB;
        public ActividadAlumnoController()
        {
            contextoDB = new ContextoDB();
        }
        // GET: api/<ActividadAlumnoController>
        [HttpGet]
        public IEnumerable<ActividadAlumno> Get()
        {
            var result = from act_al in contextoDB.ActividadAlumnos
                         join act in contextoDB.Actividades on act_al.ActividadId equals act.Id
                         join al in contextoDB.Alumnos on act_al.AlumnoId equals al.Id
                         select new ActividadAlumno
                         {
                             Id = act_al.Id,
                             AlumnoId = al.Id,
                             Alumno = new Alumno { Nombre = al.Nombre},
                             ActividadId = act.Id,
                             Actividad = new Actividad { Nombre = act.Nombre}
                         };
            return result.ToList();
        }

        // GET api/<ActividadAlumnoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ActividadAlumnoController>
        [HttpPost]
        public void Post(ActividadAlumno actividadAlumno)
        {
            actividadAlumno.Alumno = null;
            actividadAlumno.Actividad = null;
            contextoDB.ActividadAlumnos.Add(actividadAlumno);
            contextoDB.SaveChanges();
        }

        // PUT api/<ActividadAlumnoController>/5
        [HttpPut("{id}")]
        public void Put(int id, ActividadAlumno actividadAlumno)
        {
            ActividadAlumno a = contextoDB.ActividadAlumnos.Where(x => x.Id == id).FirstOrDefault();
            a.AlumnoId = actividadAlumno.AlumnoId;
            a.ActividadId = actividadAlumno.ActividadId;
            contextoDB.ActividadAlumnos.Update(a);
            contextoDB.SaveChanges();
        }

        // DELETE api/<ActividadAlumnoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ActividadAlumno act_al = contextoDB.ActividadAlumnos.Where(x=>x.Id == id).FirstOrDefault();
            contextoDB.ActividadAlumnos.Remove(act_al);
            contextoDB.SaveChanges();
        }
    }
}
