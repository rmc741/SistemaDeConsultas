namespace SistemaConsulta.Entity;

public class Usuario
{
    public long Id { get; set; }
    public string Nome { get; set; }
    public int Email { get; set;}
    public string Senha { get; set;}

    public string Situacao { get; set;}
}
