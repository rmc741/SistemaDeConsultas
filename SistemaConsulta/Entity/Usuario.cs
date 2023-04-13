namespace SistemaConsulta.Entity;

public class Usuario
{
    public Usuario(int id , string nome ,string email , string senha , string situacao )
    {
        Id = id;
        Nome = nome;
        Email = email;
        Senha = senha;
        Situacao = situacao;
    }

    public long Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set;}
    public string Senha { get; set;}

    public string Situacao { get; set;}


}
