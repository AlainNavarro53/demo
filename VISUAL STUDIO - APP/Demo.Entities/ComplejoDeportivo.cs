namespace Demo.Entities;

public class ComplejoDeportivo
{
    public int Id { get; set; }
    public string Localizacion { get; set; }
    public string JefeOrganizacion { get; set; }
    public decimal AreaTotal { get; set; }

    public int IdSedeOlimpica { get; set; }

    public SedeOlimpica
        SedeOlimpica { get; set; } // This assumes a navigation property for the foreign key relationship

    public List<ComplejoDeporteUnico> ComplejoDeporteUnico { get; set; }
    public List<ComplejoPolideportivo> ComplejoPolideportivo { get; set; }
}