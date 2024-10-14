using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp_DashBoardProfessoresMateriasComChartJs.Migrations
{
    /// <inheritdoc />
    public partial class InsercaoMateriasPorProfessor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Materias",
            columns: new[] { "Nome", "ProfessorId" },
            values: new object[,]
            {
                { "Educação Física", 4 },
                { "Biologia", 4 },
                { "História", 4 }
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Professores");

            migrationBuilder.Sql("DELETE FROM Materias");
        }
    }
}
