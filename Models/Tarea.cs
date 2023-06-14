using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projecef.Models;

public class Tarea
{
    [Key]
    public Guid TareaId { get; set; }

    [ForeignKey ("Categoria")] 
    public Guid CategoriaId { get; set; }

    [Required]
    [MaxLength(150)]

    public string Titulo { get; set; }

    public string Descripcion { get; set; }

    public Proridad ProridadTarea { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual Categoria Categoria { get; set; }

    [NotMapped]
    public string Resumen { get; set; }



}

public enum Proridad
{
    Baja,
    Media,
    Alta
}
