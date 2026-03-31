using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroAlunosAPI.Models{

[Table("alunos")]
public class Aluno
{
    
    public int Id { get; set; }

    [Required]
    public string Nome { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Telefone { get; set; }

    [Required]
    public string Curso {get; set;}

    [Required]
    [Column("data_cadastro")]
    public DateTime DataCadastro { get; set; } = DateTime.Now;
}
}