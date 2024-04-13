namespace Demo.Entities;

public class Evento
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public DateTime Fecha { get; set; }
    public string Duracion { get; set; }
    public int NroParticipantes { get; set; }

    public int? IdComplejoDeporteUnico { get; set; } // nullable for optional foreign key
    public ComplejoDeporteUnico ComplejoDeporteUnico { get; set; }

    public int? IdComplejoPolideportivo { get; set; } // nullable for optional foreign key
    public ComplejoPolideportivo ComplejoPolideportivo { get; set; }
    public List<Equipamiento> Equipamiento { get; set; }
    public List<EventoEquipamiento> EventoEquipamiento { get; set; }
    public List<Comisario> Comisarios { get; set; }
}