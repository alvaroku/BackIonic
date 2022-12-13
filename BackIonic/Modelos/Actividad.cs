using System.ComponentModel.DataAnnotations.Schema;

namespace BackIonic.Modelos
{
    public class Actividad
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
