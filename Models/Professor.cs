namespace WebApp_DashBoardProfessoresMateriasComChartJs.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public List<Materia> Materias { get; set; }           
    }
}
