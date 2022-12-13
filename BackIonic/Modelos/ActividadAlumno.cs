using System.ComponentModel.DataAnnotations.Schema;

namespace BackIonic.Modelos
{
    public class ActividadAlumno
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Alumno Alumno { get; set; }
        public int AlumnoId { get; set; }
        public Actividad Actividad { get; set; }
        public int ActividadId{get;set;}
    }
}
