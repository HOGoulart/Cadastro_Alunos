namespace CadastroAlunosAPI.Models{
using System.ComponentModel.DataAnnotations.Schema;

public class Aluno
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public string Email { get; set; }

    public string Curso {get; set;}

    [Column("data_cadastro")]
    public DateTime DataCadastro { get; set; }
}
}