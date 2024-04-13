namespace Demo.Entities;

public class ComplejoPolideportivo
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Localizacion { get; set; }
    public decimal Area { get; set; }

    public int IdComplejoDeportivo { get; set; }

    public ComplejoDeportivo
        ComplejoDeportivo { get; set; } // This assumes a navigation property for the foreign key relationship

    public List<Evento> Eventos { get; set; }
}