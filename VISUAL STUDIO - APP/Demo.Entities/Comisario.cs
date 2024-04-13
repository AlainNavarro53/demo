namespace Demo.Entities;

public class Comisario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Tipo { get; set; }

    public int IdEvento { get; set; }
    public Evento Evento { get; set; } // This assumes a navigation property for the foreign key relationship
}