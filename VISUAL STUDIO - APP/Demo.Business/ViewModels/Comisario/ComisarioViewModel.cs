namespace Demo.Business.ViewModels.Comisario;

public class ComisarioViewModel
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public int IdEvento { get; set; }
    public string EventoNombre { get; set; }
    public List<EventoViewModel>? Eventos { get; set; }
}