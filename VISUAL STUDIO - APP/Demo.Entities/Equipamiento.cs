namespace Demo.Entities;

public class Equipamiento
{
    public int Id { get; set; }
    public string Tipo { get; set; }

    public int IdEvento { get; set; }
    public Evento Evento { get; set; } // This assumes a navigation property for the foreign key relationship
    public List<EventoEquipamiento> EventoEquipamiento { get; set; }
}