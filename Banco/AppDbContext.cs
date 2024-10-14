using Microsoft.EntityFrameworkCore;
using WebApp_DashBoardProfessoresMateriasComChartJs.Models;

namespace WebApp_DashBoardProfessoresMateriasComChartJs.Banco
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Professor> Professores { get; set; }
        public DbSet<Materia> Materias { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("AppDbContext");
        //}
    }

}
