namespace WebApp_DashBoardProfessoresMateriasComChartJs.Models
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
    }
}
