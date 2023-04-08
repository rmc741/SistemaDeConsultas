namespace SistemaConsulta.Entity;

public class Consulta
{
    public long Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public DateTime DataConsulta { get ; set; }
    public string MedicoCRM { get; set; }
}
