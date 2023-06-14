namespace projecef.Models;

public class Tarea
{
    public Guid TareaId { get; set; }
    public Guid CategoriaId { get; set; }

    public string Titulo { get; set; }

    public string Descripcion { get; set; }

    public Proridad ProridadTarea { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual Categoria Categoria { get; set; }



}

public enum Proridad
{
    Baja,
    Media,
    Alta
}