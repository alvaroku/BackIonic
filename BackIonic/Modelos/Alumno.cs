using System.ComponentModel.DataAnnotations.Schema;

namespace BackIonic.Modelos
{
    public class Alumno:Login
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Grado { get; set; }
        public string Grupo { get; set; }
    }
}
