using Microsoft.EntityFrameworkCore;
using CadastroAlunosAPI.Models;

namespace CadastroAlunosAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}