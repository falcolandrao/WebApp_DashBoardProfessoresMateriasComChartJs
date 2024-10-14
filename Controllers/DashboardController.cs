using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp_DashBoardProfessoresMateriasComChartJs.Banco;

namespace WebApp_DashBoardProfessoresMateriasComChartJs.Controllers
{
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Busca todos os professores e suas respectivas matérias
            var professores = _context.Professores
                                      .Include(p => p.Materias)
                                      .ToList();

            // Agrupa as matérias por professor e conta o número de matérias que cada professor leciona
            var professoresMateriasCount = professores.Select(p => new
            {
                ProfessorNome = p.Nome,
                Materias = p.Materias
                            .GroupBy(m => m.Nome)
                            .Select(g => new { MateriaNome = g.Key, Count = g.Count() })
                            .ToList()
            }).ToList();

            return View(professoresMateriasCount);
        }

    }
}
