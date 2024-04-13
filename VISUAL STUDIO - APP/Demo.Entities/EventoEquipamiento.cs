namespace Demo.Entities;

public class EventoEquipamiento
{
    public int Id { get; set; }

    public int IdEvento { get; set; }
    public Evento Evento { get; set; } // This represents the many-to-many relationship

    public int IdEquipamiento { get; set; }
    public Equipamiento Equipamiento { get; set; } // This represents the many-to-many relationship
}