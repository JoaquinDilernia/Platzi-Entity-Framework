using System.ComponentModel.DataAnnotations;
namespace projecef.Models
{
    public class Categoria
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public ICollection<Tarea> Tareas { get; set; }
    }
}

