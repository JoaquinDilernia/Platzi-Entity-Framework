namespace projecef.Models
{
    public class Categoria
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public ICollection<Tarea> Tareas { get; set; }
    }
}

