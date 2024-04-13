namespace Demo.Entities;

public class SedeOlimpica
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Ubicacion { get; set; }
    public decimal Presupuesto { get; set; }
    public List<ComplejoDeportivo> ComplejosDeportivo { get; set; }
}